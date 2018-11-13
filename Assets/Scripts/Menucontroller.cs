using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class Menucontroller : MonoBehaviourEx {

	public void Btn_Start(){
		Debug.Log("시작버튼");
		SceneManager.LoadScene("");
	}

	public void Btn_Ranking(){
		Debug.Log("RankingScene_03");
		SceneManager.LoadScene("RankingScene_03");
	}
	public void Btn_tomenu(){
		Debug.Log("tomenu");
		SceneManager.LoadScene("MenuScene_02");
	}

}
