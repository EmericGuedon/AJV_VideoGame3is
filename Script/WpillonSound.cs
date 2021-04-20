using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WpillonSound : MonoBehaviour
{
    public bool Debug_Enabled = false;
    public AK.Wwise.Event FootstepWalk;
    public AK.Wwise.Event FootstepRun;
    public AK.Wwise.Event SwordHit;
    public AK.Wwise.Event SwordWoosh;
    public AK.Wwise.Event Shield;
    public AK.Wwise.Event Jump;

    public void Start()
    {
        AkSoundEngine.RegisterGameObj(gameObject);
    }


    public void Char_FootstepWalk(AnimationEvent evt)
    {
        if (evt.animatorClipInfo.weight > 0.5f)
        {
            Debug.Log("FT_Walk");
            FootstepWalk.Post(gameObject);
        }
    }

    public void Char_FootstepRun()
    {
        FootstepRun.Post(gameObject);
    }

    public void Char_Jump()
    {
        Jump.Post(gameObject);
    }

    public void Char_Sword()
    {
        SwordWoosh.Post(gameObject);
    }

    public void Char_SwordHit()
    {
        AkSoundEngine.SetState("Sword_Materials", "Dry");
        SwordHit.Post(gameObject);
    }

    public void Char_Shield()
    {
        Shield.Post(gameObject);
        AkSoundEngine.SetState("Sword_Materials", "Dry");
        SwordHit.Post(gameObject);
    }
}
