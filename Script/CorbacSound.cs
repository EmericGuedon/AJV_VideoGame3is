using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorbacSound : MonoBehaviour
{
    public bool Debug_Enabled = false;

    public AK.Wwise.Event FootstepWalk;
    public float ThresholdWalk;

    public AK.Wwise.Event SwordHit;
    public AK.Wwise.Event SwordWoosh;
    public AK.Wwise.Event Shield;
    public AK.Wwise.Event HitVoice;
    public AK.Wwise.Event DeathVoice;

    void Start()
    {
        AkSoundEngine.RegisterGameObj(gameObject);
    }

    public void Mob_Walk(AnimationEvent cb)
    {
        if (cb.animatorClipInfo.weight > ThresholdWalk)
        {
            Debug.Log("FT_Walk");
            FootstepWalk.Post(gameObject);
        }
    }

    public void Mob_SwordWhoosh()
    {
        SwordWoosh.Post(gameObject);
    }

    public void Mob_SwordHit()
    {
        AkSoundEngine.SetState("Sword_Materials", "Dry");
        SwordHit.Post(gameObject);
    }

    public void Mob_Shield()
    {
        Shield.Post(gameObject);
        AkSoundEngine.SetState("Sword_Materials", "Dry");
        SwordHit.Post(gameObject);
    }

    public void Mob_Hit()
    {
        HitVoice.Post(gameObject);
        AkSoundEngine.SetState("Sword_Materials", "Blood_Soft");
        SwordHit.Post(gameObject);
    }

    public void Mob_Death()
    {
        DeathVoice.Post(gameObject);
    }

}
