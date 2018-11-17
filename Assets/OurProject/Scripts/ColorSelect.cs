using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSelect : MonoBehaviour {

System.Random random = new System.Random();
[HideInInspector]public List<Color> Colors = new List<Color>();
[HideInInspector]public int[] colorPick = new int[2];
	// Use this for initialization
	void OnEnable () {
    {
        Colors.Add(Color.red);
		Colors.Add(Color.yellow);
		Colors.Add(Color.green);
		Colors.Add(Color.blue);
		Colors.Add(Color.gray);

		for(int i = 0 ; i < 2; i++)
		{
			colorPick[i] = random.Next(Colors.Count);
			while(colorPick[0] == colorPick[1])
			{
				colorPick[1] = random.Next(Colors.Count);
			}
		}
    }
	}
}
