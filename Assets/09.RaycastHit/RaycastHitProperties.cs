using UnityEngine;

public class RaycastHitProperties : MonoBehaviour
{
    public GameObject Effect;
    public GameObject normalEffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray mousePos = Camera.main.ScreenPointToRay(Input.mousePosition);

            // hit.collider
            if (Physics.Raycast(mousePos,out RaycastHit hit0, 100f))
            {
                Debug.Log("맞은 오브젝트" + hit0.collider.gameObject.name);
            }

            // hit.pont
            if (Physics.Raycast(mousePos, out RaycastHit hit1, 100f))
            {
                Instantiate(Effect, hit1.point, Quaternion.identity);
            }

            // hit.normal - 표면 방향 사용 (이펙트 정렬)
            if (Physics.Raycast(mousePos, out RaycastHit hit2, 100f))
            {
                Quaternion rot = Quaternion.LookRotation(hit2.normal); // 표면을 향하는 방향
                Instantiate(normalEffect, hit2.point, Quaternion.identity);
            }

            // distance - 광선 시작점과의 거리 확인
            if (Physics.Raycast(mousePos, out RaycastHit hit3, 100f))
            {
                Debug.Log("충돌까지 거리 :" + hit3.distance);
            }

            // transform
            if (Physics.Raycast(mousePos, out RaycastHit hit4, 100f))
            {
                hit3.transform.Rotate(Vector3.up * 10f); // 충돌한 오브젝투를 -X축으로 90회전
            }
        }
        
    }
}
