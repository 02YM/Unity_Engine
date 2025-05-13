using UnityEngine;

public class QuaternionSetFromToRotation : MonoBehaviour
{

    public Vector3 from = Vector3.forward;
    public Vector3 to = Vector3.right;
    public Quaternion rot = new Quaternion();

    void Start()
    {
        rot.SetFromToRotation(from, to);
        transform.rotation = rot;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
