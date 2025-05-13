using UnityEngine;

public class ShowPlayerViewAngle : MonoBehaviour
{
    public float length = 5f;

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
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(transform.position, transform.forward * length);

        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, length);
    }
}
