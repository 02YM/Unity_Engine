using UnityEngine;

public class DebugProperties : MonoBehaviour
{
    [SerializeField] public bool isDeveloperConsoneEnabled = false;

    void Start()
    {
        Debug.developerConsoleEnabled = true;
        Debug.Log("������ �ܼ��� Ȱ��ȭ�Ǿ����ϴ�. F1 Ű�� �� �� �ֽ��ϴ�.");
    }

    // Update is called once per frame
    void Update()
    {
        // Space Ű�� ���� �ݼ� ��� ���θ� ��� �մϴ�.
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.developerConsoleEnabled = !Debug.developerConsoleEnabled;
            Debug.Log("Console Enabled" + Debug.developerConsoleEnabled);
        }
    }
}
