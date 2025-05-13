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
            Debug.Log("SubScene ��ε� ��û��");
        }
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "SubScene")
        {
            // SubScene�� Ȱ��ȭ ������ ����
            SceneManager.SetActiveScene(scene);
            Debug.Log("Ȱ��ȭ�� �� �����" + scene.name);
        }
    }
}
