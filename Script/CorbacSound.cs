using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorbacSound : MonoBehaviour
{
    public bool Debug_Enabled = false;

    //public AK.Wwise.Event FootstepWalk;
    public float ThresholdWalk;

    //public AK.Wwise.Event SwordWoosh;
    //public AK.Wwise.Event Shield;
    //public AK.Wwise.Event HitVoice;
    //public AK.Wwise.Event DeathVoice;
    //public AK.Wwise.Event MobVoice;
    //public AK.Wwise.Event MobHit;
    //public AK.Wwise.Event SwordHit;
    //public AK.Wwise.Event Char_Swordhit;


    void Start()
    {
        AkSoundEngine.RegisterGameObj(gameObject);
    }

    private void Mob_Walk(AnimationEvent cb)
    {
        if (cb.animatorClipInfo.weight > ThresholdWalk)
        {
            AkSoundEngine.PostEvent("Footstep_Mob", gameObject);
        }
    }

    private void Mob_SwordWhoosh()
    {
        AkSoundEngine.SetState("Sword_Corbac", "None");
        AkSoundEngine.PostEvent("Sword_Mob", gameObject);
    }

    private void Mob_Hit_Shield()
    {
        AkSoundEngine.SetState("Sword_Corbac", "Dry");
        AkSoundEngine.PostEvent("Shield_Main", gameObject);
    }

    private void Mob_Shield()
    {
        AkSoundEngine.SetState("Sword_WP", "Dry");
    }

    public void Char_SwordHit()
    {
        AkSoundEngine.PostEvent("Voice_Mob", gameObject);
        AkSoundEngine.SetState("Sword_WP", "Blood_Soft");
        AkSoundEngine.PostEvent("Sword_WP", gameObject);
    }

    private void Mob_Death()
    {
        AkSoundEngine.PostEvent("VoiceDeath_Mob", gameObject);
        AkSoundEngine.SetState("Sword_WP", "Blood_Hard");
        AkSoundEngine.PostEvent("Sword_WP", gameObject);
    }

    private void Mob_Voice()
    {
        AkSoundEngine.PostEvent("Voice_Mob", gameObject);
    }
    private void Mob_Hit()
    {
        AkSoundEngine.PostEvent("Mob_Hit", gameObject);
    }

    private void Mob_BodyFall()
    {
        AkSoundEngine.PostEvent("BodyFall",gameObject);
    }

    private void Mob_Land()
    {
        AkSoundEngine.PostEvent("JumpLand_WP", gameObject);
    }
}
