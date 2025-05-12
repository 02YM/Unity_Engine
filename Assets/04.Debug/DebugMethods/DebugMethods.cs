using UnityEngine;

public class DebugMethods : MonoBehaviour
{
    [SerializeField] private float playerHP = 1;

    void Start()
    {
        Debug.Log("������ ���۵Ǿ����ϴ�.");

        Debug.LogWarning("ü���� �ʹ� �����ϴ�.!");
        
        Debug.LogError("�÷��̾� ������Ʈ�� ã�� �� �����ϴ�.");

        Debug.Assert(playerHP > 0, "�÷��̾� HP�� 0���� �Դϴ�.");        
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
