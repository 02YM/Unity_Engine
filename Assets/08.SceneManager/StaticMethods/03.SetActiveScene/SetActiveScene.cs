using UnityEngine;
using UnityEngine.SceneManagement;

public class SetActiveScene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // subScene�� �߰��ϴ� �ε�
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
            // SubScene�� Ȱ��ȭ ������ ����
            SceneManager.SetActiveScene(scene);
            Debug.Log("Ȱ��ȭ�� �� �����" + scene.name);
        }
    }
}
