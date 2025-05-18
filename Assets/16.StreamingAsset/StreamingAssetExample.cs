using UnityEngine;
using System.IO;

public class StreamingAssetExample : MonoBehaviour
{    
    void Start()
    {
        // StreamingAsset 폴더 경로에 Sample.json 파일 경로를 결합하여 ㅔㅁ소dp wjwkdgkqslek.
        string path = Path.Combine(Application.streamingAssetsPath, "Sample.json");

        // 해당 경로에 파일이 존재하는지 확인합니다.
        if(File.Exists(path))
        {
            // 파일이 존재하면 json 텍스트 파일 내용을 문자열로 읽어 옵니다.
            string json = File.ReadAllText(path);

            // 일어온 json 문자열을 streamingAssetDB 타입의 객체로 역직렬화합니다.
            StreamingAssetDB data = JsonUtility.FromJson<StreamingAssetDB>(json);

            
            Debug.Log("플레이어 이름 : " + data.playerName);
            Debug.Log("레벨 : " + data.level);
            Debug.Log("체력 : " + data.hp);
        }
        else
        {
            Debug.LogWarning("json 파일이 존재 하지 않습니다." + path);
        }
    }
}