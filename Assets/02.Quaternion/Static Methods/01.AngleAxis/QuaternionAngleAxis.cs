using UnityEngine;

// ��� ������ ȸ���� ����

public class QuaternionAngleAxis : MonoBehaviour
{
    
    void Start()
    {
        Quaternion q = Quaternion.AngleAxis(45f, Vector3.up); // y�� �������� 45��
        transform.rotation = q;
    }

}
