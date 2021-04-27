using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTag_Switch : MonoBehaviour
{
	public string SwitchGroup;
	public string SwitchName;
	public string TagName;

	private void OnTriggerEnter(UnityEngine.Collider other)
	{
		if(other.CompareTag(TagName))
        {
			AkSoundEngine.SetSwitch(SwitchGroup, SwitchName, gameObject);
		}
	}
}
