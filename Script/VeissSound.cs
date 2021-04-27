using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VeissSound : MonoBehaviour
{
    public bool Debug_Enabled = false;

    public AK.Wwise.Event FootstepWalk;
    public float ThresholdWalk;

    public AK.Wwise.Event FootstepRun;
    public float ThresholdRun;

    public AK.Wwise.Event Whoosh;
    public AK.Wwise.Event HitMassive;
    public AK.Wwise.Event BodyFall;
    public AK.Wwise.Event Hurt;
    public AK.Wwise.Event LandHard;
    public AK.Wwise.Event Death;
    public AK.Wwise.Event Gear;
    public AK.Wwise.Event Parade;

    void Start()
    {
        AkSoundEngine.RegisterGameObj(gameObject);
    }

    private void CrowM_FootstepWalk(AnimationEvent evt)
    {
        if (evt.animatorClipInfo.weight > ThresholdWalk)
        {
            Debug.Log("FT_Walk");
            AkSoundEngine.SetSwitch("CrowM_Mooving", "WALK", gameObject);
            Gear.Post(gameObject);
            FootstepWalk.Post(gameObject);
        }
    }

    private void Char_FootstepRun(AnimationEvent evt)
    {
        if (evt.animatorClipInfo.weight > ThresholdRun)
        {
                Debug.Log("FT_Run");
                AkSoundEngine.SetSwitch("WP_Mooving", "RUN", gameObject);
                FootstepRun.Post(gameObject);
        }
    }

    private void CrowM_Whoosh()
    {
        Whoosh.Post(gameObject);
    }

    private void CrowM_HitMassive()
    {
        HitMassive.Post(gameObject);
    }

    private void CrowM_BodyFall()
    {
        BodyFall.Post(gameObject);
    }

    public void CrowM_Hurt()
    {
        Hurt.Post(gameObject);
        AkSoundEngine.SetState("Sword_WP", "Blood_Soft");
        AkSoundEngine.PostEvent("Sword_WP", gameObject);
    }

    private void CrowM_JumpLandHard()
    {
        LandHard.Post(gameObject);
    }

    private void CowM_Death()
    {
        Death.Post(gameObject);
    }

    private void CrowM_Parade()
    {
        AkSoundEngine.SetState("Sword_WP", "Dry");
        Parade.Post(gameObject);
    }
}
