using UnityEngine;

public class QuaternionSetLookRotation : MonoBehaviour
{
    
    Quaternion rot = new Quaternion();

    void Start()
    {
        rot.SetLookRotation(Vector3.forward, Vector3.up); // 앞을 향하고 위는 위쪽인 회전 설정
            transform.rotation = rot;
    }

}
