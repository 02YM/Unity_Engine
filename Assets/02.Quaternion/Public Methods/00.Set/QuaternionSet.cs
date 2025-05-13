using UnityEngine;

public class QuaternionSet : MonoBehaviour
{
    public Quaternion q = new Quaternion();

    void Start()
    {
        q.Set(0f, 0.7071f, 0f, 0.701f); // 90도 y축 회전 쿼터니언 실행
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = q;
    }
}
