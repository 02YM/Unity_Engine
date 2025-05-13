using UnityEngine;

public class DebugProperties : MonoBehaviour
{
    [SerializeField] public bool isDeveloperConsoneEnabled = false;

    void Start()
    {
        Debug.developerConsoleEnabled = true;
        Debug.Log("개발자 콘솔이 활성화되었습니다. F1 키로 열 수 있습니다.");
    }

    // Update is called once per frame
    void Update()
    {
        // Space 키를 눌러 콜솔 사용 여부를 토글 합니다.
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.developerConsoleEnabled = !Debug.developerConsoleEnabled;
            Debug.Log("Console Enabled" + Debug.developerConsoleEnabled);
        }
    }
}
