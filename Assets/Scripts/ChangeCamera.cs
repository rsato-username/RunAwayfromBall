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
		// Escaper消滅で切り替え停止
		if (Escaper != null)
		{
			// Bでカメラ切り替え
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
			// ボタンでカメラ切り替え
			mainCamera.SetActive(!mainCamera.activeSelf);
			backCamera.SetActive(!backCamera.activeSelf);
		}
		else
			mainCamera.SetActive(true);
	}
}
