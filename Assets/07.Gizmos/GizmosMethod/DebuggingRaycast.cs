using UnityEngine;

public class DebuggingRaycast : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Vector3 rayDir = transform.forward * 10f;
        Gizmos.DrawRay(transform.position, rayDir);
    }
}
