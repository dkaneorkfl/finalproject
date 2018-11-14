using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        ShieldRotate();
    }

    private void ShieldRotate()
    {
        if (Input.GetMouseButtonDown(1))
        {
            transform.Rotate(0, 70, 0);
        }

        if (Input.GetMouseButtonUp(1))
        {
            transform.Rotate(0, -70, 0);
        }
    }

	void OnCollisionEnter(Collision other)
	{
		if(other.transform.tag.Equals(transform.tag))
		{
			Debug.Log("Absolve!");
		}
		else if(other.transform.tag != transform.tag)
		{
			Debug.Log("Damaged!");
		}
	}
}
