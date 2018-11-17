using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreIndicator : MonoBehaviour{

[SerializeField]private GameObject Player;
private float Score;

private string ScoreString;
    private void Update() 
	{
		Score = Player.GetComponent<PlayerDirector>().Score;
		ScoreString = Score.ToString();
		GetComponent<Text>().text = ScoreString;
	}
}
