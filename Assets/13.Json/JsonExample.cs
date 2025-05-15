using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public string playerName;
    public int level;
    public float health;
}

public class JsonExample : MonoBehaviour
{    

    void Start()
    {
        // 1. 예제용 PlayerData생성
        PlayerData player = new PlayerData();
        player.playerName = "Dydals";
        player.level = 5;
        player.health = 87.5f;

        // 2. 객체를 JSON 문자열로 변환
        string json = JsonUtility.ToJson(player);
        Debug.Log("> JSON으로 변환한 데이터 :\n" + json);


        // 3. JSON 문자열을 다시 객체로 역질렬화
        PlayerData loadedPlayer = JsonUtility.FromJson<PlayerData>(json);
        Debug.Log("> 복원된 Player 데이터 :");
        Debug.Log("이름 : " + loadedPlayer.playerName);
        Debug.Log("레벨 : " + loadedPlayer.level);
        Debug.Log("체력 : " + loadedPlayer.health);

    }

}
