using UnityEngine;

public class QuaternionSlerpUnClamped : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion a = transform.rotation;
        Quaternion b = Quaternion.Euler(0, 90, 0);

        Quaternion result = Quaternion.SlerpUnclamped(a, b, 2f * Time.deltaTime);

        transform.rotation = result;
    }
}
