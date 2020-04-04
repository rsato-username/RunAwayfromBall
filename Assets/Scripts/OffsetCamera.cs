using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetCamera : MonoBehaviour
{
	public GameObject Escaper;
	private Vector3 offset;

	void Start()
	{
		offset = transform.position - Escaper.transform.position;
	}

	void Update()
	{
		transform.position = Escaper.transform.position + offset;
	}
}