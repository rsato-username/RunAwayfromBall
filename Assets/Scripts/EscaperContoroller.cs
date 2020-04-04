using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscaperContoroller : MonoBehaviour
{
	public GameObject Retry;
	public GameObject mainCamera;

	void Start()
	{
		this.Retry = GameObject.Find("RetryMenu");
		Retry.SetActive(false);
	}

	void OnTriggerEnter(Collider collision)
	{
		mainCamera.SetActive(true);
		Destroy(gameObject);
		Retry.SetActive(true);
    }
}
