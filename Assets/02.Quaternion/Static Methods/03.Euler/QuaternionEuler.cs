using UnityEngine;
// ���Ϸ� ������ ���ʹϾ����� ��ȯ

public class QuaternionEuler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Quaternion rotation = Quaternion.Euler(0, 90, 0);
        transform.rotation = rotation;
    }
}
