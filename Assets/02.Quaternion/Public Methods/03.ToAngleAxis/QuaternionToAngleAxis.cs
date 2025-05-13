using UnityEngine;

public class QuaternionToAngleAxis : MonoBehaviour
{
    Quaternion q = Quaternion.Euler(0, 90, 0); // 90�� Y�� ȸ��
    

    void Start()
    {
        q.ToAngleAxis(out float angle, out Vector3 axis);
        Debug.Log($"Angle : {angle}, Anxis :{axis}");

        transform.rotation = q;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
