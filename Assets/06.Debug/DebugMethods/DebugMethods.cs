using UnityEngine;

public class DebugMethods : MonoBehaviour
{
    [SerializeField] private float playerHP = 1;

    void Start()
    {
        Debug.Log("게임이 시작되었습니다.");

        Debug.LogWarning("체력이 너무 낮습니다.!");
        
        Debug.LogError("플레이어 오브젝트를 찾을 수 없습니다.");

        Debug.Assert(playerHP > 0, "플레이어 HP가 0이하 입니다.");        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.ClearDeveloperConsole();
            Debug.Break();
        }

        Debug.DrawLine(transform.position, Vector3.up * 5, Color.red, 5f);
    }
}
