using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
	private float seconds;
	public GameObject Oni;
	public GameObject OniGenerator;
	private float oldSeconds;
	private Text CountDownText;

	void Start()
	{
		seconds = 10.0f;
		oldSeconds = 10.0f;
		CountDownText = GetComponentInChildren<Text> ();
		this.Oni = GameObject.Find("Oni");
		this.OniGenerator = GameObject.Find("OniGenerator");
		Oni.SetActive(false);
		OniGenerator.SetActive(false);
	}

	void Update()
	{
		// カウントダウン
		if (seconds <= 10.0f)
		{
			seconds -= Time.deltaTime;
			if((int)seconds != (int)oldSeconds)
			{
				CountDownText.text = ((int) seconds).ToString ("0");
			}
			oldSeconds = seconds;
		}
		// 鬼活動開始
		if (seconds < 0)
		{
			Oni.SetActive(true);
			OniGenerator.SetActive(true);
			Destroy(gameObject);
		}
    }
}
