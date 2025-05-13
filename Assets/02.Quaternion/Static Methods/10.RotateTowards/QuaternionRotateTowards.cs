using UnityEngine;

// a���� b�� ���� ������ŭ ȸ��

public class QuaternionRotateTowards : MonoBehaviour
{
    public float Speed = 30f;

    // Update is called once per frame
    void Update()
    {
        Quaternion a = transform.rotation;
        Quaternion b = Quaternion.Euler(0, 90, 0);

        float maxDegressDelta = Speed * Time.deltaTime;

        transform.rotation = Quaternion.RotateTowards(a, b, maxDegressDelta);
    }
}
