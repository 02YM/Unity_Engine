using UnityEngine;

// 두 쿼터니언 사이의 유사도 계산(-1 ~ 1)

public class QuaternionDot : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Quaternion a = Quaternion.Euler(0, 0, 0);
        Quaternion b = Quaternion.Euler(0, 90, 0);

        float dot = Quaternion.Dot(a, b);
        Debug.Log("Dot 의 값 : " + dot);
    }
}
