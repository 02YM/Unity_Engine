using UnityEngine;

public class QuaternionSetLookRotation : MonoBehaviour
{
    
    Quaternion rot = new Quaternion();

    void Start()
    {
        rot.SetLookRotation(Vector3.forward, Vector3.up); // ���� ���ϰ� ���� ������ ȸ�� ����
            transform.rotation = rot;
    }

}
