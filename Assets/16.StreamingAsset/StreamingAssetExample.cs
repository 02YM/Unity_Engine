using UnityEngine;
using System.IO;

public class StreamingAssetExample : MonoBehaviour
{    
    void Start()
    {
        // StreamingAsset ���� ��ο� Sample.json ���� ��θ� �����Ͽ� �Ĥ���dp wjwkdgkqslek.
        string path = Path.Combine(Application.streamingAssetsPath, "Sample.json");

        // �ش� ��ο� ������ �����ϴ��� Ȯ���մϴ�.
        if(File.Exists(path))
        {
            // ������ �����ϸ� json �ؽ�Ʈ ���� ������ ���ڿ��� �о� �ɴϴ�.
            string json = File.ReadAllText(path);

            // �Ͼ�� json ���ڿ��� streamingAssetDB Ÿ���� ��ü�� ������ȭ�մϴ�.
            StreamingAssetDB data = JsonUtility.FromJson<StreamingAssetDB>(json);

            
            Debug.Log("�÷��̾� �̸� : " + data.playerName);
            Debug.Log("���� : " + data.level);
            Debug.Log("ü�� : " + data.hp);
        }
        else
        {
            Debug.LogWarning("json ������ ���� ���� �ʽ��ϴ�." + path);
        }
    }
}