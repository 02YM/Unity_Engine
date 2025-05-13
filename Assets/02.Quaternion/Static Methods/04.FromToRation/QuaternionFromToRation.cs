using UnityEngine;

// �� ������ �ٸ� �������� ȸ�� ��Ű�� ȸ�� ����
public class QuaternionFromToRation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 from = Vector3.back;
        Vector3 to = Vector3.right;

        Quaternion rot = Quaternion.FromToRotation(from, to);

        transform.rotation = rot;
    }
}
