using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private int minute;
	[SerializeField] private float seconds;
	[SerializeField] private float countdown;
	[SerializeField] public GameObject Escaper;
	private float oldSeconds; // 前のUpdateの時の秒数
	public Text timerText; // タイマー表示用テキスト
 
	void Start () {
		minute = 0;
		seconds = 0;
		oldSeconds = 0;
		timerText = GetComponentInChildren<Text>();
	}
 
	void Update () {
		if (countdown < 10)
			countdown += Time.deltaTime;
		if (countdown >= 10)
		{
			if (Escaper != null)
			{
				seconds += Time.deltaTime;
				if (seconds >= 60)
				{
					minute++;
					seconds = seconds - 60;
				}
				if ((int)seconds != (int)oldSeconds)
				{
					timerText.text = minute.ToString("00") + ":" + ((int) seconds).ToString("00");
				}
				oldSeconds = seconds;
			}
		}
	}
}
