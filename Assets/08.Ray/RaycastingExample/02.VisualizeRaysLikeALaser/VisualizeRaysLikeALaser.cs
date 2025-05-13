using UnityEngine;

public class VisualizeRaysLikeALaser : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = transform.forward;
        Debug.DrawRay(transform.position, direction * 10f, Color.green);
    }
}
