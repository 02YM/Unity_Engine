using UnityEngine;

public class QuaternionSet : MonoBehaviour
{
    public Quaternion q = new Quaternion();

    void Start()
    {
        q.Set(0f, 0.7071f, 0f, 0.701f); // 90�� y�� ȸ�� ���ʹϾ� ����
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = q;
    }
}
