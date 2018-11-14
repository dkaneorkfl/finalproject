using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class GetColor : MonoBehaviour {
Material myMaterial;
Random random = new Random();

int[] c = new int[2];

List<Color> Colors = new List<Color>();
	void Start () {
		SetColorList();

		myMaterial = GetComponent<Renderer>().material;
		myMaterial.SetColor("Team1",Colors[c[0]]);
		myMaterial.SetColor("Team2",Colors[c[1]]);
		if(transform.tag == "Team1")
			myMaterial.color = myMaterial.GetColor("Team1");
		if(transform.tag == "Team2")
			myMaterial.color = myMaterial.GetColor("Team2");
	}

    private void SetColorList()
    {
        Colors.Add(Color.red);
		Colors.Add(Color.yellow);
		Colors.Add(Color.green);
		Colors.Add(Color.blue);
		Colors.Add(Color.gray);

		for(int i = 0 ; i < 2; i++)
		{
			c[i] = random.Next(Colors.Count);
			while(c[0] == c[1])
			{
				c[1] = random.Next(Colors.Count);
			}
		}
    }
}
