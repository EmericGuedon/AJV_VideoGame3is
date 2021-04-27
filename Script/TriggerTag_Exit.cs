using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTag_Exit : MonoBehaviour
{
	public AK.Wwise.Event EventName;
	public string TagName;

    private void OnTriggerExit(UnityEngine.Collider other)
	{
		if(other.CompareTag(TagName))
        {
			EventName.Post(gameObject);
		}
	}
}
