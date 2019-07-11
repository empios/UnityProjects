using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovment : MonoBehaviour
{
	public Transform[] cameraPosition;
	private int count = 1;
	private float speed = 2f;
	

	void Update()
	{
	if(Input.GetKeyDown(KeyCode.F))
		{
			if (count == 3)
			{
				count = 0;
			}
			else
				count++;
		}
	}
	
	private void FixedUpdate()
	{
		transform.position = Vector3.Lerp(transform.position, cameraPosition[count].position, speed * Time.deltaTime);
		transform.rotation = Quaternion.Lerp(transform.rotation, cameraPosition[count].rotation, speed * Time.deltaTime);
	}
}
