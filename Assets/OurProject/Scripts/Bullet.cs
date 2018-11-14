using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour {
	// 총알 삭제 시간
	public float destroyTime = 4f;

	// Use this for initialization
/// <summary>
/// OnCollisionEnter is called when this collider/rigidbody has begun
/// touching another rigidbody/collider.
/// </summary>
/// <param name="other">The Collision data associated with this collision.</param>


void Start()
{
	Destroy( gameObject, destroyTime );
}

void Update()
{	// 발사된 총알 삭제 코드
	transform.Translate(0,0, Time.deltaTime);
}


void OnCollisionEnter(Collision other)
{
	if(other.transform.tag=="Enemy")
	{
		Destroy(other.gameObject);
		Destroy(gameObject);
	}



}

}
