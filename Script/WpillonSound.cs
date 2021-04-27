using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WpillonSound : MonoBehaviour
{
    public bool Debug_Enabled = false;

    //public AK.Wwise.Event FootstepWalk;
    public float ThresholdWalk;

    //public AK.Wwise.Event FootstepRun;
    public float ThresholdRun;

    //public AK.Wwise.Event MobHit_WP;
    //public AK.Wwise.Event SwordWoosh;
    //public AK.Wwise.Event Shield;
    //public AK.Wwise.Event Jump;
    //public AK.Wwise.Event Hurt;
    //public AK.Wwise.Event Land;
    //public AK.Wwise.Event LandHard;
    //public AK.Wwise.Event WP_Dead;
    //public AK.Wwise.Event WP_AttaqueC;
    //public AK.Wwise.Event WP_BodyFall;



    private void Start()
    {
        AkSoundEngine.RegisterGameObj(gameObject);
    }


    private void Char_FootstepWalk(AnimationEvent evt)
    {
        if (evt.animatorClipInfo.weight > ThresholdWalk)
        {          
            AkSoundEngine.SetSwitch("WP_Mooving", "WALK", gameObject);
            AkSoundEngine.PostEvent("Footstep_WP", gameObject);
        }
    }

    private void Char_FootstepRun(AnimationEvent evt)
    {
        if (evt.animatorClipInfo.weight > ThresholdRun)
        {
            AkSoundEngine.SetSwitch("WP_Mooving", "RUN", gameObject);
            AkSoundEngine.PostEvent("Footstep_WP", gameObject);
        }
    }

    private void Char_Jump()
    {
        AkSoundEngine.PostEvent("Jump_WP", gameObject);
    }
    private void Char_JumpLand()
    {
        AkSoundEngine.PostEvent("JumpLand_WP", gameObject);
    }
    private void Char_JumpLandHard()
    {
        AkSoundEngine.PostEvent("JumpLand_Hard_WP", gameObject);
    }

    private void WP_Sword()
    {
        AkSoundEngine.SetState("Sword_WP", "None");
        AkSoundEngine.PostEvent("Sword_WP", gameObject);
    }

    public void WP_Shield()
    {
        AkSoundEngine.SetState("Sword_Corbac", "Dry");
        AkSoundEngine.PostEvent("Shield_Main", gameObject);
    }

    private void WP_Hurt()
    {
        //AkSoundEngine.SetState("Sword_Corbac", "Blood_Soft");
        //AkSoundEngine.PostEvent("Sword_Mob", gameObject);
        AkSoundEngine.PostEvent("WP_Hurt", gameObject);
    }

    private void WP_Death()
    {
        AkSoundEngine.PostEvent("WP_Death", gameObject);
    }
    private void Char_BodyFall()
    {
        AkSoundEngine.PostEvent("BodyFall", gameObject);
    }

    private void WP_SwordC()
    {
        AkSoundEngine.PostEvent("WP_AttaqueC", gameObject);
    }

}


