using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CharacterMoving : MonoBehaviour {
	//사용 카메라 등록
	public Camera Sight;
	
	float rtSpeed = 5;
	float mSpeed = 20;
	
	void Start () {

		Cursor.lockState = CursorLockMode.Locked;
				Cursor.visible=false;
	}
	void Update () {
		
		MoveCtrl();
		RotCtrl();
	}
	void MoveCtrl(){
		if(Input.GetKey(KeyCode.W)){
			Debug.Log("앞");
			transform.Translate(Vector3.forward*Time.deltaTime*mSpeed);
		}
		if(Input.GetKey(KeyCode.S)){
			Debug.Log("뒤");
			transform.Translate(Vector3.back*Time.deltaTime*mSpeed);
		}
		if(Input.GetKey(KeyCode.D)){
			Debug.Log("오른");
			transform.Translate(Vector3.right*Time.deltaTime*mSpeed);
		}
		if(Input.GetKey(KeyCode.A)){
			Debug.Log("왼");
			transform.Translate(Vector3.left*Time.deltaTime*mSpeed);
		}
	}	

	
	void RotCtrl(){
		// Cursor.lockState=CursorLockMode.Locked;
		
		float rotX = Input.GetAxis("Mouse Y")*rtSpeed;
		
		float rotY = Input.GetAxis("Mouse X")*rtSpeed;
		

		//this.transform.localRotation*=Quaternion.Euler(0,rotY,0);
		
		Sight.transform.rotation*=Quaternion.Euler(0,rotY,0);
		Sight.transform.rotation*=Quaternion.Euler(-rotX,0,0);
		

		Sight.transform.eulerAngles = new Vector3(Sight.transform.eulerAngles.x,Sight.transform.eulerAngles.y,0);
		
		
	}
}
