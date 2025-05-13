using UnityEngine;

public class ShowPatrolPath : MonoBehaviour
{
    public Transform[] waypoints;
    public float positionRadius = 0.3f;

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
        for(int i=0; i<waypoints.Length; i++)
        {
            if (i + 1 >= waypoints.Length) break;
            Gizmos.DrawLine(waypoints[i].position, waypoints[i + 1].position);
            Gizmos.DrawWireSphere(waypoints[i].position, positionRadius);
        }

        // ������ ����Ʈ �� �׸���, ������ ����Ʈ���� ó�� ����Ʈ ���� �� ����
        if (waypoints.Length > 0)
        {
            Gizmos.DrawWireSphere(waypoints[waypoints.Length - 1].position, 0.3f);
            Gizmos.DrawLine(waypoints[waypoints.Length - 1].position, waypoints[0].position);
        }
    }
}
