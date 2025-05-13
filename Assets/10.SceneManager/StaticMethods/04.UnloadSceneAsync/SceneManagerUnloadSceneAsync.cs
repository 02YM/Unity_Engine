using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerUnloadSceneAsync : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SceneManager.LoadScene("SubScene", LoadSceneMode.Additive);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            SceneManager.UnloadSceneAsync("SubScene");
            Debug.Log("SubScene 언로드 요청됨");
        }
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "SubScene")
        {
            // SubScene을 활성화 씬으로 설정
            SceneManager.SetActiveScene(scene);
            Debug.Log("활성화된 씬 변경됨" + scene.name);
        }
    }
}
