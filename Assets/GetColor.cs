using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetColor : MonoBehaviour {
Material myMaterial;
	void Start () {
		myMaterial = GetComponent<Renderer>().material;
		myMaterial.SetColor("Team1",new Color(1,0,0,1));
		myMaterial.SetColor("Team2",new Color(0,0,1,1));
		if(transform.tag == "Team1")
		{
			myMaterial.color = myMaterial.GetColor("Team1");
		}
		if(transform.tag == "Team2")
		{
			myMaterial.color = myMaterial.GetColor("Team2");
		}
	}
}
