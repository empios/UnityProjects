using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onClick : MonoBehaviour
{

	public GameObject Beholder;
	public GameObject Cube;
	// Start is called before the first frame update
	void Start()
	{
		Beholder.SetActive(false);
	}

    // Update is called once per frame
    void Update()
    {
		if (Input.GetMouseButtonDown(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit, Mathf.Infinity))
			{
				if (hit.collider.gameObject == this.gameObject && Beholder.activeInHierarchy == false )
				{
					Beholder.SetActive(true);
					Cube.SetActive(false);
				}
				else if (hit.collider.gameObject == this.gameObject && Beholder.activeInHierarchy == true)
				{
					Beholder.SetActive(false);
					Cube.SetActive(true);
				}
			}
		}
	}
}
