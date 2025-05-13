using UnityEngine;
using UnityEngineInternal;

public class LineofSight : MonoBehaviour
{
    public Transform target;           // �÷��̾� �Ǵ� Ÿ��
    public float viewDistance = 20f; // �ִ� �þ� �Ÿ�
    public float fieldOfView = 60f; // �þ߰�(�� + ��)
    public Vector3 directionToTarget;
    public float distanceToTarget;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(CanSeePlayer())
        {
            Debug.Log("�÷��̾ ã�ҽ��ϴ�.");
        }
    }

    bool CanSeePlayer()
    {
        // ����
        directionToTarget = (target.transform.position - transform.position).normalized;
        // �Ÿ�
        distanceToTarget = Vector3.Distance(transform.position, target.position);

        // �þ߰� üũ
        float angle = Vector3.Angle(transform.forward, directionToTarget);
        if (angle > fieldOfView * 0.5f)
            return false;

        Debug.DrawRay(transform.position, directionToTarget * viewDistance, Color.yellow);

        // ���� ĳ��Ʈ�� ��ֹ� üũ
        Ray ray = new Ray(transform.position, directionToTarget);
        if(Physics.Raycast(ray, out RaycastHit hit, viewDistance))
        {
            if(hit.transform == target)
            {
                return true;
            }
        }

        return false;
    }

    private void OnDrawGizmos()
    {
        // ���� ������ �ƴϸ� �׸��� �ʵ��� ����
        //if (!Application.isPlaying) return;

        // ���� ������Ʈ�� ���� ���� ���͸� �����ɴϴ�.
        Vector3 forward = transform.forward;
        // �þ߰��� ������ ���(����, ������ ������ ����)
        float halfFOV = fieldOfView * 0.5f;

        // ���� �������� ȸ���� ȸ���� ���� (Y�� ����)
        Quaternion leftRayRotation = Quaternion.Euler(0, -halfFOV, 0);
        // ������ �������� ȸ���� ȸ���� ����(Y�� ����)
        Quaternion rightRayRotation = Quaternion.Euler(0, halfFOV, 0);

        // ���� ���͸� ���� ȸ������ ���ο� ���� ���� ����
        Vector3 leftRayDirection = leftRayRotation * forward;
        // ���� ���͸� ������ ȸ�� ���� ���ο� ���� ���� ����
        Vector3 rightRayDirection = rightRayRotation * forward;

        Gizmos.color = Color.cyan;
        Gizmos.DrawRay(transform.position, leftRayDirection * viewDistance);
        Gizmos.DrawRay(transform.position, rightRayDirection * viewDistance);
    }
}
