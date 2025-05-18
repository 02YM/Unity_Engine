using UnityEngine;

public class TextAssetExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TextAsset textAsset = Resources.Load<TextAsset>("15.TextAsset/Sample");

        if(textAsset != null)
        {
            Debug.Log("15.TextAsset/Sample 파일이 존재합니다");
        }
        else
        {
            Debug.Log("Sample 파일이 존재하지 않습니다.");
            Debug.Log("Resources폴더에 15.TextAsset/Sample 만들어 주세요");
        }
    }
}
