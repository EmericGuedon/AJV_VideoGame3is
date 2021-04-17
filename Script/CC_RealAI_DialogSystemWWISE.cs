using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Invector.vCharacterController.AI
{
    [RequireComponent(typeof(AudioSource))]

    public class CC_RealAI_DialogSystemWWISE : MonoBehaviour
    {

        public string ChaseWwiseA;
        public string ChaseWwiseB;
        public string DeadWwiseA;
        public string DeadWwiseB;


        [Header("Enemy_System")]
        public AudioClip SFXDialog;
        private AudioSource theaudio;

        [Header("Enemy A")]

        public v_AIController EnemysA;
        public AudioClip[] AlertSFXA;
        public AudioClip[] DieSFXA;

        [Header("Enemy B")]

        public v_AIController EnemysB;
        public AudioClip[] AlertSFXB;
        public AudioClip[] DieSFXB;

        private bool DeadA;
        private bool DeadB;

        // Start is called before the first frame update
        void Start()
        {
            theaudio = GetComponent<AudioSource>();
            theaudio.clip = SFXDialog;
            
            EnemysA.onChase.AddListener(ChaselistenerA);
            EnemysB.onChase.AddListener(ChaselistenerB);
        }

        // Update is called once per frame
        public void LaunchDialog()
        {
            theaudio.Play();
            StartCoroutine(ReturnToPatrol());
        }
        //CHASE SFX
        private void ChaselistenerA()
        {
            StopAllCoroutines();
            theaudio.Stop();
            theaudio.clip = AlertSFXA[Random.Range(0, AlertSFXA.Length)];
            theaudio.Play();
            //Wwise
            AkSoundEngine.PostEvent(ChaseWwiseA, gameObject);
        }
        private void ChaselistenerB()
        {
            StopAllCoroutines();
            theaudio.Stop();
            theaudio.clip = AlertSFXB[Random.Range(0, AlertSFXB.Length)];
            theaudio.Play();
            //Wwise
            AkSoundEngine.PostEvent(ChaseWwiseB, gameObject);
        }

        private void Update()
        {
            if ((EnemysA.currentHealth == 0) && !DeadA)
             {
                DeadA = true;
                DeadlistenerA();
             }


            if ((EnemysB.currentHealth == 0) && !DeadB)
            {
                DeadB = true;
                DeadlistenerB();
            }

        }
        //DEAD SFX
        private void DeadlistenerA()
        {
            theaudio.Stop();
            theaudio.clip = DieSFXA[Random.Range(0, DieSFXA.Length)];
            theaudio.Play();
            //wwise
            AkSoundEngine.PostEvent(DeadWwiseA, gameObject);
        }

        private void DeadlistenerB()
        {
            theaudio.Stop();
            theaudio.clip = DieSFXB[Random.Range(0, DieSFXB.Length)];
            theaudio.Play();
            //wwise
            AkSoundEngine.PostEvent(DeadWwiseB, gameObject);
        }

        IEnumerator ReturnToPatrol()
        {
            yield return new WaitForSeconds(SFXDialog.length);

            EnemysA.MoveTo(Random.insideUnitSphere * 5, 1, 2);
            EnemysB.MoveTo(Random.insideUnitSphere * 5, 1, 2);
        }

    }
}
