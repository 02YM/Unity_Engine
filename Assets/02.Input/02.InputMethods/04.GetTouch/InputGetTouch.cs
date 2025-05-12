using UnityEngine;

// ����� ��� ��ġ�� ��������ϴ�.
// Windows > General > Device Simulator�� ������ּ���.

public class InputGetTouch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount >0)
        {
            Touch t = Input.GetTouch(0);
            if (t.phase == TouchPhase.Began)
                Debug.Log($"Touched at {t.position}");
        }
    }
}
