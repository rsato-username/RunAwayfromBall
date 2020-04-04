using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OniGenerator : MonoBehaviour
{
	public GameObject Escaper;
	public GameObject OniPrefab;
	float span = 10.0f;
	float delta = 0;
	float flag = 0;

	void Update()
	{
		if (Escaper != null)
		{
			this.delta += Time.deltaTime;
			// 時間経過で鬼生成頻度上昇
			if (this.flag >= 6)
				this.span = 5;
			if (this.flag >= 12)
				this.span = 2.5f;
			if (this.flag >= 15)
				this.span = 1;
			if (this.delta > this.span)
			{
				this.flag++;
				this.delta = 0;
				GameObject Oni = Instantiate(OniPrefab) as GameObject;
				int x = Random.Range(-45, 45);
				int z = Random.Range(-45, 45);
				Oni.transform.position = new Vector3(x, 0.5f, z);
			}
		}
	}
}
