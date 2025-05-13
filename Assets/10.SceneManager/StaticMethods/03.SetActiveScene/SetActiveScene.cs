using UnityEngine;
using UnityEngine.SceneManagement;

public class SetActiveScene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // subScene을 추가하는 로드
        SceneManager.LoadScene("SubScene", LoadSceneMode.Additive);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if(scene.name == "SubScene")
        {
            // SubScene을 활성화 씬으로 설정
            SceneManager.SetActiveScene(scene);
            Debug.Log("활성화된 씬 변경됨" + scene.name);
        }
    }
}
