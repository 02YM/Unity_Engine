using UnityEngine;
using UnityEngineInternal;

public class LineofSight : MonoBehaviour
{
    public Transform target;           // 플레이어 또는 타겟
    public float viewDistance = 20f; // 최대 시야 거리
    public float fieldOfView = 60f; // 시야각(좌 + 우)
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
            Debug.Log("플레이어를 찾았습니다.");
        }
    }

    bool CanSeePlayer()
    {
        // 방향
        directionToTarget = (target.transform.position - transform.position).normalized;
        // 거리
        distanceToTarget = Vector3.Distance(transform.position, target.position);

        // 시야각 체크
        float angle = Vector3.Angle(transform.forward, directionToTarget);
        if (angle > fieldOfView * 0.5f)
            return false;

        Debug.DrawRay(transform.position, directionToTarget * viewDistance, Color.yellow);

        // 레이 캐시트로 장애물 체크
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
        // 실행 중이지 아니면 그리지 않도록 제한
        //if (!Application.isPlaying) return;

        // 현재 오브젝트의 정면 방향 벡터를 가져옵니다.
        Vector3 forward = transform.forward;
        // 시야각의 절반을 계산(왼쪽, 오른쪽 나누기 위함)
        float halfFOV = fieldOfView * 0.5f;

        // 왼쪽 방향으로 회전한 회전값 생성 (Y축 기준)
        Quaternion leftRayRotation = Quaternion.Euler(0, -halfFOV, 0);
        // 오른쪽 방향으로 회전한 회전값 생성(Y축 기준)
        Quaternion rightRayRotation = Quaternion.Euler(0, halfFOV, 0);

        // 정면 벡터를 왼쪽 회전시켜 새로운 방향 벡터 생성
        Vector3 leftRayDirection = leftRayRotation * forward;
        // 정면 벡터를 오른쪽 회전 시켜 새로운 방향 벡터 생성
        Vector3 rightRayDirection = rightRayRotation * forward;

        Gizmos.color = Color.cyan;
        Gizmos.DrawRay(transform.position, leftRayDirection * viewDistance);
        Gizmos.DrawRay(transform.position, rightRayDirection * viewDistance);
    }
}
