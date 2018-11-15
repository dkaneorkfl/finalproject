using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldControl : MonoBehaviour {

string forTagCompare;
[SerializeField]GameObject Sheild;
	// Use this for initialization
	void Start () {
		forTagCompare = $"{Sheild.transform.tag}"+".Bullet";
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

	void OnTriggerEnter(Collider other)
	{
		if(forTagCompare == transform.tag && other.gameObject == Sheild)
		{
			Debug.Log("Absolve by Shield!");
		}
		else if(forTagCompare != transform.tag && other.gameObject == Sheild)
		{
			Debug.Log("Pierced by Bullet!");
		}
	}
}
