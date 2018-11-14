using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GameController_Esc : MonoBehaviour {
	//esc버튼 누르면 팝업창 나오게.
	public GameObject Pausemenu;
	private void Start()
	{
		
	}
	 void Update () {	
		

		 if(Input.GetKeyDown(KeyCode.Escape)){
			
			if(Pausemenu.gameObject.activeInHierarchy==false){
				Pausemenu.gameObject.SetActive(true);
				Debug.Log("매뉴 팝업 창이 나옴");
				Cursor.lockState = CursorLockMode.Confined;
				Cursor.visible=true;
				
			}
			else if(Pausemenu.gameObject.activeInHierarchy==true){
				Pausemenu.gameObject.SetActive(false);
				
				Cursor.lockState = CursorLockMode.None;
				Debug.Log("매뉴 팝업 창이 사라짐");	
			}
		}
		// if(Pausemenu.gameObject.activeInHierarchy==true&&Input.GetKeyDown(KeyCode.Escape)){
		// 	Debug.Log("마우스 다시 센터");
		// 	Cursor.lockState = CursorLockMode.Locked;
		// 	Cursor.visible=true;
		// }
	}
}
