using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTag_State : MonoBehaviour
{
	public string StateGroup;
	public string StateName;
	public string TagName;

	private void OnTriggerEnter(UnityEngine.Collider other)
	{
		if(other.CompareTag(TagName))
        {
			AkSoundEngine.SetState(StateGroup, StateName);
		}
	}
}
