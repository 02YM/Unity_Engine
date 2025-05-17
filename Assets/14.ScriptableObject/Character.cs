using UnityEngine;

public class Character : MonoBehaviour
{

    public CharacterStats stats;

    void Start()
    {
        Debug.Log($"캐릭터 이름 {stats.characterName}");
        Debug.Log($"레벨 : {stats.level}, 최대 HP : {stats.maxHP}, 공격력 : {stats.attackPower}");
    }

}
