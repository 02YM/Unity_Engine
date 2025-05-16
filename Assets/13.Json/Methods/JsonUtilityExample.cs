using UnityEngine;

// ��ü ���� ���
// 1. ��ü -> JSON ���ڿ��� ��ȯ
// 2. JSON ���ڿ� -> �� ��ü�� ��ȯ
// 3. JSON ���ڿ� -> ���� ��ü�� �����


// ��ü �帧 ���
// ����       ���                 ���ø޼���                        ���
//   1        ��ü->Json���ڿ�     JsonUtility.ToJson(obj)           ����/���ۿ� ���
//   2        Json ���ڿ�->��ü    JsonUtility.FromJson<T>()         Json�� �� ��ü�� ������ȭ
//   3        ���� ��ü �����   JsonUtility.FromJsonOverwrite()   ���� �̽��Ͻ��� �ʵ常 ���(���Ҵ� �ƴ�)


// Unity�� �� Ŭ������ ����ȭ�� �� �ֵ��� ǥ��(�ʼ�!)
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
        //(1). ToJson : ��ü�� JSON �������� ��ȯ
        PlayerDataStatus orinalData = new PlayerDataStatus
        {
            playerName = "Dydals",
            level = 10,
            hp = 75.5f
        };
        

        string json = JsonUtility.ToJson(orinalData);
        // 1. �ܰ� : ToJson - ��ü -> Json ���ڿ�
        // �׸�                                                 ����        
        // PlayerDdataStatus : ��ü ����        ->              "Dydals" �̸��� �÷��̼� ����
        Debug.Log("> ToJson ��� : \n" + json);


        //(2). FromJson<T> : JSON ���ڿ��� �� ��ü�� ������ȭ
        string newJson = "{ \"playerName\" : \"NewBie\", \"level\" : 1 ,\"hp\":100.0}";
        PlayerDataStatus newPlayer = JsonUtility.FromJson<PlayerDataStatus>(newJson);

        // 2. �ܰ� : FromJson<T> - Json���ڿ� -> �� ��ü
        // �׸�                                                 ����
        // newJson                                              �ùٸ� Json ������ ���ڿ�
        // FromJson<T>()                                        ���ڿ��� ��� ���ο� PlayerDataStatus ��ü ����
        // ���                                                  "NewBie", level, hp 100.0 ���� �� ��ü ������

        Debug.Log("> FromJson ��� :");
        Debug.Log($"�̸� : {newPlayer.playerName}, ���� : {newPlayer.level}, ä�� : {newPlayer.hp}");

        //3. FromJsonOverwite : ���� ��ü�� ���� ����
        string overwiteJson = "{ \"playerName\" : \"Overwitten\" , \"level\" : 99, \"hp\" : 999.9}";
        JsonUtility.FromJsonOverwrite(overwiteJson, orinalData);

        // (3)
        // �׸�                                                 ����
        // ���� ��ü orinalData                                 "Dydals", 10, 75.5 ���¿���
        // FromJsonOverWrite()                                 �ش� Json ������ ��ü�� ������ ���
        // ���                                                orinalData ��ü�� "Overwirtten", 99, 999.9 ������ ���ŵ�
        Debug.Log("> FromJsonOverwite ��� (originalData�� �����):");
        Debug.Log($"�̸� : {orinalData.playerName}, ���� : {orinalData.level}, ü�� : {orinalData.hp}");
        
    }
}
