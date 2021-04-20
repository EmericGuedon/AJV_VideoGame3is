using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorbacSound : MonoBehaviour
{
    public AK.Wwise.Event FootstepWalk;
    public AK.Wwise.Event SwordHit;
    public AK.Wwise.Event SwordWoosh;
    public AK.Wwise.Event Shield;
    public AK.Wwise.Event HitVoice;
    public AK.Wwise.Event DeathVoice;

    void Start()
    {
        AkSoundEngine.RegisterGameObj(gameObject);
    }

    void Mob_Walk()
    {
        FootstepWalk.Post(gameObject);
    }

    void Mob_SwordWhoosh()
    {
        SwordWoosh.Post(gameobject);
    }

    void Mob_SwordHit()
    {
        AkSoundEngine.SetState("Sword_Materials", "Dry");
        SwordHit.Post(gameobject);
    }

    void Mob_Shield()
    {
        Shield.Post(gameObject);
        AkSoundEngine.SetState("Sword_Materials", "Dry");
        SwordHit.Post(gameObject);
    }

    void Mob_Hit()
    {
        HitVoice.Post(gameobject);
    }

    void Mob_Death()
    {
        DeathVoice.Post(gameobject);
    }

}
