using UnityEngine;

// 두 쿼터니언 사이클 선형 보간 (0 ~ 1)

public class QuaternionLerp : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Quaternion a = Quaternion.Euler(0,0,0);
        Quaternion b = Quaternion.Euler(0, 90, 0);

        Quaternion result = Quaternion.Lerp(a, b, 0.5f);

        transform.rotation = result;
    }

}
