using UnityEngine;

// ĳ���� �տ� �ִ� ��ֹ�, �� Ž��, �� �ٵ��� ����

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
            Debug.Log("���𰡿� ����"+hit.collider.name);
        }
    }
}
