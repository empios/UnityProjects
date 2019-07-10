using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movment : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.F))
		{
			if (gameObject.GetComponent<Rigidbody>() == true)
			{
				gameObject.GetComponent<Rigidbody>().AddForce(10, 10, 10, ForceMode.Impulse);
			}
			else gameObject.AddComponent<Rigidbody>().AddForce(10,10,10, ForceMode.Impulse);
			Debug.Log("F pressed");
		}
    }
}
