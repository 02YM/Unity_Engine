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
            // 오브젝트 이름 과 거리를 함께 출력합니다.
            // F2는 소수점 둘째 자리까지 출력하기 위한 포맷입니다.
            Debug.Log($"박스 안에 있는 오브젝트{col.name}, 선의 길이 {distance:F2}");

            Gizmos.DrawLine(transform.position, col.transform.position);
        }
    }
}
