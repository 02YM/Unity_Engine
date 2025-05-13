using UnityEngine;

public class QuaternionLookRotation : MonoBehaviour
{

    public Transform Target;

    // Update is called once per frame
    void Update()
    {
        Quaternion rot = Quaternion.LookRotation(Target.position,Vector3.up);

        transform.rotation = rot;
    }
}
