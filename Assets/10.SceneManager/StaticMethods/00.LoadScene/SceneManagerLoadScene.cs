using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerLoadScene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            // GameScene을 로드합니다.
            SceneManager.LoadScene("GameScene");
        }
    }
}
