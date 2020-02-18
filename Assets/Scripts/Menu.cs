using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
	public GameObject commandPanel;

    public void ClosePanel()
    {
		this.commandPanel = GameObject.Find("CommandPanel");
        commandPanel.SetActive(false);
    }

	public void OpenPanel()
    {
        commandPanel.SetActive(true);
    }
}
