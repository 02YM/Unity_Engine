using UnityEngine;

public class Character : MonoBehaviour
{

    public CharacterStats stats;

    void Start()
    {
        Debug.Log($"ĳ���� �̸� {stats.characterName}");
        Debug.Log($"���� : {stats.level}, �ִ� HP : {stats.maxHP}, ���ݷ� : {stats.attackPower}");
    }

}
