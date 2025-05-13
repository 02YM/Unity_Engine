using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerLoadSceneAsync : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(LoadLoadingScene());                    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator  LoadLoadingScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("LoadingScene");

        while(!asyncLoad.isDone)
        {
            Debug.Log("�ε� ��..." + asyncLoad.progress);
            yield return null;
        }

        Debug.Log("�ε� �Ϸ�");
    }
}
