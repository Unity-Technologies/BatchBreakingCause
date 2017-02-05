using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class DisableCameraDepthSorting : MonoBehaviour 
{
	void Start () 
	{
		Camera.main.opaqueSortMode = UnityEngine.Rendering.OpaqueSortMode.NoDistanceSort;
	}
}
