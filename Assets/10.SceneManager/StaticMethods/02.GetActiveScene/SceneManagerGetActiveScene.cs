using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerGetActiveScene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        Debug.Log("���� Ȱ�� �� :" + currentScene.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
