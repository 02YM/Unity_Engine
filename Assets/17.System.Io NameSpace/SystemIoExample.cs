using UnityEngine;
using System.IO;
// System.IO + JsonUtility + persistentDataPath�� Ȱ���� �⺻���� ���̺�/ �ε� �ý��� �����Դϴ�.

public class SystemIoExample : MonoBehaviour
{
    // ����. �ҷ������ JSON������ �̸��� �����մϴ�.
    string fileName = "SystemIoData.json";

    void Start()
    {
        // ���ο� SystemIoData ��ü�� ����� �÷��̾� �̸�, ����, ü���� �ʱ�ȭ �մϴ�.
        SystemIoData data = new SystemIoData()
        {
            playerName = "Dydals",
            level = 24,
            hp = 427
        };

        // �����͸� ���Ϸ� �����ϴ� �޼����Դϴ�.
        SaveData(data);

        // ����� JSON ������ �ҷ��� ��ü�� ������ȭ�մϴ�.
        SystemIoData loadedPlayer = LoadData();
        if(loadedPlayer != null)
        {
            Debug.Log($"�ҷ��� �÷��̾� : {loadedPlayer.playerName}, ���� : {loadedPlayer.level}, HP : {loadedPlayer.hp}");
        }

    }

    // SystemIoData ��ü�� Json���� �����ϴ� �Լ��Դϴ�.
    void SaveData(SystemIoData data)
    {
        // ��ü�� ���� ���� JSON ���ڿ��� ��ȯ�մϴ�.
        string json = JsonUtility.ToJson(data, true);
        // �ü���� ���� ��ο� ������ ���ļ� ��ü ��θ� �����մϴ�.
        string path = Path.Combine(Application.persistentDataPath, fileName);
        // JSON���ڿ��� ���Ͽ� �����մϴ�.
        File.WriteAllText(path, json);
        Debug.Log("���� �Ϸ� : " + path);
    }

    // JSON ���Ͽ��� �����͸� �ҷ����� �Լ��Դϴ�.
    SystemIoData LoadData()
    {
        // ����� JSON ������ ��ü ��θ� �����մϴ�.
        string path = Path.Combine(Application.persistentDataPath, fileName);

        // �ش� ��ο� ������ ������ �����ϴ��� Ȯ���մϴ�.
        if(File.Exists(path))
        {
            // ������ ������ ���ڿ��� �о�ɴϴ�.
            string json = File.ReadAllText(path);
            // JSON ���ڿ��� �ٽ� SystemIoData ��ü�� ��ȯ�մϴ�.
            SystemIoData data = JsonUtility.FromJson<SystemIoData>(json);
            return data;
        }
        else
        {
            Debug.LogWarning("���� ������ �����ϴ�." + path);
            return null;
        }
    }


}
