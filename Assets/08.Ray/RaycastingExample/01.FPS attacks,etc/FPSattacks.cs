using UnityEngine;

// 캐릭터 앞에 있는 장애물, 적 탐지, 벽 바딪힘 감지

public class FPSattacks : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, 100f))
        {
            Debug.DrawLine(ray.origin, hit.point, Color.red);
            Debug.Log("무언가에 맞음"+hit.collider.name);
        }
    }
}
