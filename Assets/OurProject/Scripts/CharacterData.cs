using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class CharacterData : MonoBehaviour {

	GameObject stageSetter;
internal Color team1Color;
internal Color team2Color;
internal string Team1 = "Team1";
internal string Team2 = "Team2";

public virtual void OnEnable()
{
	stageSetter= GameObject.Find("Plane");
	ColorSelect SSRC = stageSetter.GetComponent<ColorSelect>();
	team1Color = SSRC.Colors[SSRC.colorPick[0]];
	team2Color = SSRC.Colors[SSRC.colorPick[1]];
}
public virtual void GetColor()
{
	if(transform.tag == Team1)
		GetComponent<Renderer>().material.color = team1Color;
	if(transform.tag == Team2)
		GetComponent<Renderer>().material.color = team2Color;
}
}
