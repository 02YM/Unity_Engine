using UnityEngine;
using System.IO;
// System.IO + JsonUtility + persistentDataPath를 활용한 기본적인 세이브/ 로드 시스템 구조입니다.

public class SystemIoExample : MonoBehaviour
{
    // 저장. 불러오기용 JSON파일의 이름을 지정합니다.
    string fileName = "SystemIoData.json";

    void Start()
    {
        // 새로운 SystemIoData 객체를 만들고 플레이어 이름, 레벨, 체력을 초기화 합니다.
        SystemIoData data = new SystemIoData()
        {
            playerName = "Dydals",
            level = 24,
            hp = 427
        };

        // 데이터를 파일로 저장하는 메서드입니다.
        SaveData(data);

        // 저장된 JSON 파일을 불러와 객체로 역직렬화합니다.
        SystemIoData loadedPlayer = LoadData();
        if(loadedPlayer != null)
        {
            Debug.Log($"불러온 플레이어 : {loadedPlayer.playerName}, 레벨 : {loadedPlayer.level}, HP : {loadedPlayer.hp}");
        }

    }

    // SystemIoData 객체를 Json으로 저장하는 함수입니다.
    void SaveData(SystemIoData data)
    {
        // 객체를 보기 좋은 JSON 문자열로 변환합니다.
        string json = JsonUtility.ToJson(data, true);
        // 운영체제별 저장 경로와 파일을 합쳐서 전체 경로를 생성합니다.
        string path = Path.Combine(Application.persistentDataPath, fileName);
        // JSON문자열을 파일에 저장합니다.
        File.WriteAllText(path, json);
        Debug.Log("저장 완료 : " + path);
    }

    // JSON 파일에서 데이터를 불러오는 함수입니다.
    SystemIoData LoadData()
    {
        // 저장된 JSON 파일의 전체 경로를 생성합니다.
        string path = Path.Combine(Application.persistentDataPath, fileName);

        // 해당 경로에 파일이 실제로 존재하는지 확인합니다.
        if(File.Exists(path))
        {
            // 파일의 내용을 문자열로 읽어옵니다.
            string json = File.ReadAllText(path);
            // JSON 문자열을 다시 SystemIoData 객체로 변환합니다.
            SystemIoData data = JsonUtility.FromJson<SystemIoData>(json);
            return data;
        }
        else
        {
            Debug.LogWarning("저장 파일이 없습니다." + path);
            return null;
        }
    }


}
