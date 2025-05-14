using UnityEngine;

public class PlayerPrefsMethods : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerPrefs.SetInt("HighScore", 1000);
        PlayerPrefs.SetFloat("Volume", 0.8f);
        PlayerPrefs.SetString("UserName", "Dydals");
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        int score = PlayerPrefs.GetInt("HighScore");
        float volume = PlayerPrefs.GetFloat("Volume");
        string userName = PlayerPrefs.GetString("UserName");

        Debug.Log("Score : " + score);
        Debug.Log("Volume : " + volume);
        Debug.Log("UserName : " + userName);
    }
}
