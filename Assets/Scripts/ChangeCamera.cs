using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
	[SerializeField] private GameObject mainCamera;
	[SerializeField] private GameObject backCamera;
	[SerializeField] private GameObject Escaper;

	void Update()
	{
		if (Escaper != null)
		{
			if (Input.GetKeyDown(KeyCode.B))
			{
				mainCamera.SetActive(!mainCamera.activeSelf);
				backCamera.SetActive(!backCamera.activeSelf);
			}
		}
	}

	public void changeCamera()
	{
		if (Escaper != null)
		{
			mainCamera.SetActive(!mainCamera.activeSelf);
			backCamera.SetActive(!backCamera.activeSelf);
		}
		else
			mainCamera.SetActive(true);
	}
}
