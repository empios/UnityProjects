using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class zmniejsz : MonoBehaviour
{
	private Animator animator;
	public GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
		animator = GetComponent<Animator>();
		
    }

    // Update is called once per frame
    void Update()
    {
		if (sphere.transform.position.y < -1f)
		{
			StartCoroutine(zmniejszanie());
			
		}
    }

	public IEnumerator zmniejszanie()
	{
		animator.SetBool("zmniejsz", true);
		yield return new WaitForSeconds(3f);
		Destroy(gameObject);

	}
}
