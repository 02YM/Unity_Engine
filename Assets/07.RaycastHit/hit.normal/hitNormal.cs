using UnityEngine;

public class hitNormal : MonoBehaviour
{
    public float rayDistance = 10f;

    private RaycastHit hit;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        if(Physics.Raycast(ray, out hit, rayDistance))
        {
            // ���⼭ hit ������ �����մϴ�.
        }
    }

    private void OnDrawGizmos()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        Gizmos.color = Color.red;
        Gizmos.DrawRay(ray.origin, ray.direction * rayDistance);

        if(Physics.Raycast(ray, out hit, rayDistance))
        {
            // ���� ���� ǥ��
            Gizmos.color = Color.yellow;
            Gizmos.DrawSphere(hit.point, 0.3f);

            // Normal ���� �ð�ȭ
            Gizmos.color = Color.green;
            Gizmos.DrawRay(hit.point, hit.normal);
        }
    }
}
