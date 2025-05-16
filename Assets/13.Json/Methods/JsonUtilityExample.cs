using UnityEngine;

// 전체 구조 요약
// 1. 객체 -> JSON 문자열로 변환
// 2. JSON 문자열 -> 새 객체로 변환
// 3. JSON 문자열 -> 기존 객체에 덮어쓰기


// 전체 흐름 요약
// 순번       기능                 관련메서드                        비고
//   1        객체->Json문자열     JsonUtility.ToJson(obj)           저장/전송에 사용
//   2        Json 문자열->객체    JsonUtility.FromJson<T>()         Json을 새 객체로 역직렬화
//   3        기존 객체 덮어쓰기   JsonUtility.FromJsonOverwrite()   기존 이스턴스의 필드만 덮어씀(재할당 아님)


// Unity가 이 클래스를 직렬화할 수 있도록 표시(필수!)
[System.Serializable]
public class PlayerDataStatus
{
    public string playerName;
    public int level;
    public float hp;
}

public class JsonUtilityExample : MonoBehaviour
{

    void Start()
    {
        //(1). ToJson : 객체를 JSON 문지열로 반환
        PlayerDataStatus orinalData = new PlayerDataStatus
        {
            playerName = "Dydals",
            level = 10,
            hp = 75.5f
        };
        

        string json = JsonUtility.ToJson(orinalData);
        // 1. 단계 : ToJson - 객체 -> Json 문자열
        // 항목                                                 설명        
        // PlayerDdataStatus : 객체 생성        ->              "Dydals" 이름의 플레이서 생성
        Debug.Log("> ToJson 결과 : \n" + json);


        //(2). FromJson<T> : JSON 문자열을 새 객체로 역직렬화
        string newJson = "{ \"playerName\" : \"NewBie\", \"level\" : 1 ,\"hp\":100.0}";
        PlayerDataStatus newPlayer = JsonUtility.FromJson<PlayerDataStatus>(newJson);

        // 2. 단계 : FromJson<T> - Json문자열 -> 새 객체
        // 항목                                                 설명
        // newJson                                              올바른 Json 형식의 문자열
        // FromJson<T>()                                        문자열을 기반 새로운 PlayerDataStatus 객체 생성
        // 결과                                                  "NewBie", level, hp 100.0 값이 들어간 객체 생성됨

        Debug.Log("> FromJson 결과 :");
        Debug.Log($"이름 : {newPlayer.playerName}, 레벨 : {newPlayer.level}, 채력 : {newPlayer.hp}");

        //3. FromJsonOverwite : 기존 객체에 덮어 쓰기
        string overwiteJson = "{ \"playerName\" : \"Overwitten\" , \"level\" : 99, \"hp\" : 999.9}";
        JsonUtility.FromJsonOverwrite(overwiteJson, orinalData);

        // (3)
        // 항목                                                 설명
        // 기존 객체 orinalData                                 "Dydals", 10, 75.5 상태였음
        // FromJsonOverWrite()                                 해당 Json 값으로 객체의 내용을 덮어씀
        // 결과                                                orinalData 객체가 "Overwirtten", 99, 999.9 값으로 갱신됨
        Debug.Log("> FromJsonOverwite 결과 (originalData에 덮어쓰기):");
        Debug.Log($"이름 : {orinalData.playerName}, 레벨 : {orinalData.level}, 체력 : {orinalData.hp}");
        
    }
}
