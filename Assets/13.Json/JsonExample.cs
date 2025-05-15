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
        // 1. ������ PlayerData����
        PlayerData player = new PlayerData();
        player.playerName = "Dydals";
        player.level = 5;
        player.health = 87.5f;

        // 2. ��ü�� JSON ���ڿ��� ��ȯ
        string json = JsonUtility.ToJson(player);
        Debug.Log("> JSON���� ��ȯ�� ������ :\n" + json);


        // 3. JSON ���ڿ��� �ٽ� ��ü�� ������ȭ
        PlayerData loadedPlayer = JsonUtility.FromJson<PlayerData>(json);
        Debug.Log("> ������ Player ������ :");
        Debug.Log("�̸� : " + loadedPlayer.playerName);
        Debug.Log("���� : " + loadedPlayer.level);
        Debug.Log("ü�� : " + loadedPlayer.health);

    }

}
