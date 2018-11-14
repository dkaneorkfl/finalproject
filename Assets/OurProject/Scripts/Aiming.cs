using System.Collections;
using System.Collections.Generic;using UnityEngine;

using System.Linq;

public class Aiming : MonoBehaviour
{
GameObject fireposition;

public GameObject x ;
public GameObject y;
	Camera camera;
private Vector3 ScreenCenter;
Ray ray;
RaycastHit raycastHit;
 
	public float damage = 10f;
	public float range = 100f;
	[SerializeField]private GameObject _bullet;
    // Use this for initialization
    public Camera FirstPersonCharacter;
	
	private void Start()
	{
		fireposition = GameObject.Find("Sphere");
	}

	void Update () 
	{

		if(Input.GetMouseButtonDown(0)){
			Short();
	}

	}

	void Short()
	{
		// RaycastHit hit;
		// Physics.Raycast(FirstPersonCharacter.transform.position, FirstPersonCharacter.transform.forward,out hit, range );
		// {	
		// 	GameObject bullet = Instantiate(_bullet,fireposition.transform.position,Quaternion.Euler(transform.localEulerAngles));
		// 	bullet.GetComponent<Rigidbody>().AddForce(Vector3.forward*100);

			
			if(Input.GetMouseButtonDown (0) ) { //Basic attack controls

       		Vector3 curTarget = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Debug.Log (curTarget);
            var worldTarget = Input.mousePosition;
            Quaternion rot = Quaternion.LookRotation(transform.position - curTarget, Vector3.right);
            GameObject bullet = Instantiate (_bullet, transform.position, rot);

			// Target target = hit.transform.GetComponent<Target>();
			// if (target != null)
			// {
			// 	target.TakeDamage(damage);
			// }
		}
	}
}
