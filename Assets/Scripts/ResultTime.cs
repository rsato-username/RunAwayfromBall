using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultTime : MonoBehaviour
{
	public Timer timer;
	private Text result;
	bool once = true;

    void Update()
    {
		if (once)
		{
			result = GetComponentInChildren<Text>();
			result.text = timer.timerText.text;
			once = false;
		}
    }
}
