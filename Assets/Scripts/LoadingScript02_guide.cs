using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LoadingScript02_guide : MonoBehaviour {

	 public Image slider;
    bool IsDone = false;
    float fTime = 0f;
    AsyncOperation async_operation;
 
    void Start()
    {
        StartCoroutine(StartLoad("MenuScene_02"));
    }
 
    void Update()
    {
        fTime += Time.deltaTime;
        slider.fillAmount = fTime;
 
        if (fTime >= 5)
        {
            async_operation.allowSceneActivation = true;
        }
    }
 
    public IEnumerator StartLoad(string strSceneName)
    {
        async_operation = SceneManager.LoadSceneAsync(strSceneName);
        async_operation.allowSceneActivation = false;
 
        if (IsDone == false)
        {
            IsDone = true;
 
            while (async_operation.progress < 0.9f)
            {
                slider.fillAmount = async_operation.progress;
 
                yield return true;
            }
        }
    }
}
 
