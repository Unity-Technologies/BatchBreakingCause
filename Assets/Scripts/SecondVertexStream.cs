using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondVertexStream : MonoBehaviour
{
	public Mesh secondVertexStream;

	void Start () 
	{
		this.GetComponent<MeshRenderer>().additionalVertexStreams = secondVertexStream;
	}
}
