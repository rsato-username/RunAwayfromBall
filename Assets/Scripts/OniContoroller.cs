using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class OniContoroller : MonoBehaviour
{
	public NavMeshAgent Oni;
	public GameObject Escaper;
    void Start()
    {
        Oni = gameObject.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Escaper != null)
		{
			Oni.destination = Escaper.transform.position;
		}
    }
}
