using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDirector : MonoBehaviour {
GameObject t1;
GameObject t2;
GameObject weapon;
GameObject Shield;
Color c1;
Color c2;
	// Use this for initialization
	void Start () {
		t1 = GameObject.Find("Team1");
		t2 = GameObject.Find("Team2");
		c1 = t1.GetComponent<Renderer>().material.color;
		c2 = t2.GetComponent<Renderer>().material.color;
		Debug.Log($"{c1},{c2}");
		weapon = GameObject.Find("Cylinder");
		Shield = GameObject.Find("Cube");
	}
	
	// Update is called once per frame
	void Update () {
		ColorChange();
	}

    private void ColorChange()
    {
        if(Input.GetMouseButtonDown(2))
		{
			if(transform.tag == "Team1")
			{
				Debug.Log("Color Change2");
				ChangeObjcet(gameObject, "Team2", c2);
				ChangeObjcet(weapon, "Team2", c2);
				ChangeObjcet(Shield, "Team2", c2);
			}
			else if(transform.tag == "Team2")
			{
				Debug.Log("Color Change1");
				ChangeObjcet(gameObject, "Team1", c1);
				ChangeObjcet(weapon, "Team1", c1);
				ChangeObjcet(Shield, "Team1", c1);
				Debug.Log(c1);
			}
    	}
	}

    private void ChangeObjcet(GameObject a, string b, Color c)
    {
        a.transform.tag = b;
		a.GetComponent<Renderer>().material.color = c;
    }
}
