using UnityEngine;

// a에서 b로 일정 각도만큼 회전

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
