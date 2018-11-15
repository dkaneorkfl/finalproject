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
public float HP;
public float MaxHP;
public float Score;
List<GameObject> ObjectList = new List<GameObject>();
	// Use this for initialization
	void Start () {
		t1 = GameObject.Find("Team1");
		t2 = GameObject.Find("Team2");

		c1 = t1.GetComponent<Renderer>().material.color;
		c2 = t2.GetComponent<Renderer>().material.color;

		weapon = GameObject.Find("Cylinder");
		Shield = GameObject.Find("Cube");

		ObjectList.Add(gameObject);
		ObjectList.Add(weapon);
		ObjectList.Add(Shield);

		ChangeObjcet(ObjectList, "Team1", c1);

		MaxHP = 10;
		HP = MaxHP;
		Score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		ColorChange();
		PlayerDead();
	}

    private void PlayerDead()
    {
        if(HP == 0)
		{
			Debug.Log("Player is Dead!");
			HP = 10;
		}
    }

    private void ColorChange()
    {
        if(Input.GetMouseButtonDown(2))
		{
			if(transform.tag == "Team1")
			{
				Debug.Log("Color Change2");
				ChangeObjcet(ObjectList, "Team2", c2);
			}
			else if(transform.tag == "Team2")
            {
				ChangeObjcet(ObjectList, "Team1", c1);
            }
        }
	}

    private void ChangeObjcet(List<GameObject> a, string b, Color c)
    {
		foreach (GameObject item in a)
		{
		item.transform.tag = b;
		item.GetComponent<Renderer>().material.color = c;	
		}
        
    }
}
