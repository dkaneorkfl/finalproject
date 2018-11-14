using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class RayViewer : MonoBehaviour
{
	public float weaponRange = 50f;

	private Camera fspCam;

	
	void Start ()
	{			
		fspCam = GetComponentInParent<Camera> ();
	}
	
	
	
	void Update () 
	{		
		Vector3 lineOrigin = fspCam.ViewportToWorldPoint (new Vector3(0.5f, 0.5f, 0));
		Debug.DrawRay (lineOrigin,fspCam.transform.forward* weaponRange,Color.green);
	} 

}

