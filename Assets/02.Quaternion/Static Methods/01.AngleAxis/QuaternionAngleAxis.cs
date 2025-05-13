using UnityEngine;

// 축과 각도로 회전을 생성

public class QuaternionAngleAxis : MonoBehaviour
{
    
    void Start()
    {
        Quaternion q = Quaternion.AngleAxis(45f, Vector3.up); // y축 기준으로 45도
        transform.rotation = q;
    }

}
