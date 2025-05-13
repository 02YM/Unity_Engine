using UnityEngine;

// ���� ���� ���� (�ڿ������� ȸ��)

public class QuaternionSlerp : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Quaternion a = transform.rotation;
        Quaternion b = Quaternion.Euler(0, 90, 0);

        Quaternion result = Quaternion.Slerp(a, b, 0.5f * Time.deltaTime);

        transform.rotation = result;
    }
}
