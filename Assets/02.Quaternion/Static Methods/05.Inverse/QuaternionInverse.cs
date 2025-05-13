using UnityEngine;

// 역회전 반환

public class QuaternionInverse : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Quaternion origin = Quaternion.Euler(0, 90, 0);
        Quaternion inverse = Quaternion.Inverse(origin);

        transform. rotation = inverse;
    }

}
