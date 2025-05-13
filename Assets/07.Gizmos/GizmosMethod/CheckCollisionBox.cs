using UnityEngine;

public class CheckCollisionBox : MonoBehaviour
{
    public Vector3 boxSize = new Vector3(2, 1, 2);
    public LayerMask detectionLayer;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireCube(transform.position, boxSize);

        Collider[] colliders = Physics.OverlapBox(transform.position, boxSize, Quaternion.identity, detectionLayer);

        foreach(Collider col in colliders)
        {
            float distance = Vector3.Distance(transform.position, col.transform.position);
            // ������Ʈ �̸� �� �Ÿ��� �Բ� ����մϴ�.
            // F2�� �Ҽ��� ��° �ڸ����� ����ϱ� ���� �����Դϴ�.
            Debug.Log($"�ڽ� �ȿ� �ִ� ������Ʈ{col.name}, ���� ���� {distance:F2}");

            Gizmos.DrawLine(transform.position, col.transform.position);
        }
    }
}
