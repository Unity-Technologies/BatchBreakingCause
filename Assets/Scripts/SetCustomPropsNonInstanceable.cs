using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class SetCustomPropsNonInstanceable : MonoBehaviour
{
	public MeshRenderer[] meshRenderers;
	public Color[] colors;

	void Start () 
	{
		MaterialPropertyBlock mpb = new MaterialPropertyBlock();

		for (int i = 0; i < meshRenderers.Length; ++i)
		{
			mpb.SetColor("_Color", colors[i]);		// instanceable
			mpb.SetFloat("_Metallic", 1.0f);		// not instanceable
			meshRenderers[i].SetPropertyBlock(mpb);
		}
	}
}
