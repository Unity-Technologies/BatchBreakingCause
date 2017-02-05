using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticBatchUtility : MonoBehaviour 
{
	void Start () 
	{
		StaticBatchingUtility.Combine(gameObject);
	}
}
