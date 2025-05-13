using UnityEngine;

public class QuaternionLerpUnclamped : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Quaternion a = Quaternion.Euler(0, 0, 0);
        Quaternion b = Quaternion.Euler(0, 90, 0);

        Quaternion result = Quaternion.LerpUnclamped(a, b, 1.5f);

        transform.rotation = result;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
