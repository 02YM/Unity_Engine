using UnityEngine;

// �� ���ʹϾ� ������ ���絵 ���(-1 ~ 1)

public class QuaternionDot : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Quaternion a = Quaternion.Euler(0, 0, 0);
        Quaternion b = Quaternion.Euler(0, 90, 0);

        float dot = Quaternion.Dot(a, b);
        Debug.Log("Dot �� �� : " + dot);
    }
}
