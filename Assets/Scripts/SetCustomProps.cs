using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class SetCustomProps : MonoBehaviour
{
	public MeshRenderer[] MeshRenderers;
	public Color[] Colors;

	void Start () 
	{
		MaterialPropertyBlock mpb = new MaterialPropertyBlock();

		for (int i = 0; i < MeshRenderers.Length; i++)
		{
			mpb.SetColor("_Color", Colors[i]);
			MeshRenderers[i].SetPropertyBlock(mpb);
		}
	}
}
