using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class FollowingCursorCamera : MonoBehaviour
{
//   public float xSensitivity = 1.0f;
//     public float ySensitivity = 1.0f;
//     public Camera cam;
//     private void OnRenderImage(RenderTexture src, RenderTexture dest)
//     {
//         Graphics.Blit(src ,dest);
        
//     }

//     // Use this for initialization
//     void Start() {

//         Cursor.lockState = CursorLockMode.Locked;
//         Cursor.visible=true;
//     }

//     // Update is called once per frame
//     void Update() {

//         //회전하고 싶은 축과 입력축이 반대인 것에 유의
//         float yRot = Input.GetAxis("Mouse X") * xSensitivity;
//         float xRot = Input.GetAxis("Mouse Y") * ySensitivity;

//         //오브젝트(기준이 되는 축을 유지해야 됨)와 카메라 회전을 분리해야 됨
//         //쿼터니안은 곱해야 누적됨
//         this.transform.localRotation *= Quaternion.Euler(0, yRot, 0);
//         cam.transform.localRotation *= Quaternion.Euler(-xRot, 0, 0);//부호 주의
//     }
    
}