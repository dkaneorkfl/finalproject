using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multishot : MonoBehaviour {
public List<GameObject> multi;
public GameObject Origin;
public int way;

public float degree;
	// Use this for initialization
	void Start () {
		for(int i=0; i<way; i++)
		{
			multi.Add(Origin);
			multi[i] = Instantiate(Origin,gameObject.transform.position,Quaternion.AngleAxis((i*degree), transform.up));
		}
		if(way <= 1){
			Instantiate(Origin,gameObject.transform.position,transform.rotation);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
