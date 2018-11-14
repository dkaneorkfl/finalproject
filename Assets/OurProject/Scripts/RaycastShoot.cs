using System.Collections;
using System.Collections.Generic;using UnityEngine;

using System.Linq;

public class RaycastShoot : MonoBehaviour
{
	public GameObject _bullet ;
	public int gunDamge = 1;
	public float frireRate = .25f;
	public float weaponRange = 50f;
	public float hitForce = 100f;
	public Transform gunEnd;

	private Camera fpsCam;
	private WaitForSeconds shotDuration = new WaitForSeconds(.07f);
	private AudioSource gunAudio;
	private LineRenderer laserLine;
	private float nextFire;
	
	void Start ()
	{		
		laserLine = GetComponent<LineRenderer> ();
		gunAudio = GetComponent<AudioSource> ();
		fpsCam = GetComponentInParent<Camera>();
	}
	
	
	
	void Update () 
	{		
		if (Input.GetButtonDown("Fire1") && Time.time> nextFire)
		{
			nextFire = Time.time + frireRate;

			// StartCoroutine(ShotEffect());

			Vector3 rayOrigin = fpsCam.ViewportToWorldPoint (new Vector3(0.5f, 0.5f, 0));
			RaycastHit hit;

			laserLine.SetPosition(0, gunEnd.position);

			if (Physics.Raycast(rayOrigin,fpsCam.transform.forward, out hit, weaponRange))
			{
				laserLine.SetPosition(1, rayOrigin + (fpsCam.transform.forward*weaponRange));
				Debug.Log(fpsCam.transform.position);
				
				GameObject Bullet = Instantiate(_bullet,new Vector3(fpsCam.transform.position.x,fpsCam.transform.position.y,fpsCam.transform.position.z+2),fpsCam.transform.rotation);
				Bullet.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward*100);
			}

		
			
			
		}
	}
	// private IEnumerator ShotEffect()
	// {
	// 	gunAudio.Play ();

	// 	laserLine.enabled = true;
	// 	yield return shotDuration;
	// 	laserLine.enabled = false;
	// }

}
