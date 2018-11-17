using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageDirector : MonoBehaviour {
public List<GameObject> EnemyList;
public List<GameObject> Boss;
int enemyCount;
int stageNumber;
Vector3 randomPosition;
public GameObject Player;
int EnemyTime =50;
// 적이 나는 시간의 간격
int EnemyLife ;
	// Use this for initialization
	void Start () {
		stageNumber=2;
		enemyCount=stageNumber*10;

	}
	
	// Update is called once per frame
	void Update ()
    {
		EnemyTime = EnemyTime-1;
		Debug.Log(EnemyTime);
		if(EnemyTime <= 0)
		{
		EnemyLife = 10;
		for(int i=0 ; i<stageNumber ; i++)
		{
			RandomPosition();
     	   EnemyLifeS();
		}
		EnemyTime=50;
		}


    }

    private void EnemyLifeS()
    {
        GameObject Enemy = Instantiate(EnemyList[0], randomPosition,transform.rotation);
		Enemy.transform.LookAt(Player.transform);
		Debug.Log("등장");
        Destroy(Enemy, 10);
    }

    private void RandomPosition()
    {
		randomPosition = new Vector3(UnityEngine.Random.Range(-25,25),1.42f,UnityEngine.Random.Range(-25,25));
    }
}
