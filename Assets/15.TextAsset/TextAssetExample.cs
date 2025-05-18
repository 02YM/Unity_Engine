using UnityEngine;

public class TextAssetExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TextAsset textAsset = Resources.Load<TextAsset>("15.TextAsset/Sample");

        if(textAsset != null)
        {
            Debug.Log("15.TextAsset/Sample ������ �����մϴ�");
        }
        else
        {
            Debug.Log("Sample ������ �������� �ʽ��ϴ�.");
            Debug.Log("Resources������ 15.TextAsset/Sample ����� �ּ���");
        }
    }
}
