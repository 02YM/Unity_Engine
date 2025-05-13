using UnityEngine;

// 두 쿼터니언 간의 회전 각도를 구함 (0 ~ 180도)

public class QuaternionAngle : MonoBehaviour
{
    
    void Start()
    {
        Quaternion a = Quaternion.Euler(0, 0, 0);
        Quaternion b = Quaternion.Euler(0, 90, 0);

        float angle = Quaternion.Angle(a, b);

        Debug.Log("두 회전 간의 각도" + angle); // 출력 0,90,0
    }

    
}
