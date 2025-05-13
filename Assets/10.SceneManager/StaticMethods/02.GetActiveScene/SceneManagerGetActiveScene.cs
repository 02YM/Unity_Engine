using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerGetActiveScene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        Debug.Log("ÇöÀç È°¼º ¾À :" + currentScene.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
