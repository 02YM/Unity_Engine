using UnityEngine;

// �� ���ʹϾ� ���� ȸ�� ������ ���� (0 ~ 180��)

public class QuaternionAngle : MonoBehaviour
{
    
    void Start()
    {
        Quaternion a = Quaternion.Euler(0, 0, 0);
        Quaternion b = Quaternion.Euler(0, 90, 0);

        float angle = Quaternion.Angle(a, b);

        Debug.Log("�� ȸ�� ���� ����" + angle); // ��� 0,90,0
    }

    
}
