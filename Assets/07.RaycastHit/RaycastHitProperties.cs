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
                Debug.Log("���� ������Ʈ" + hit0.collider.gameObject.name);
            }

            // hit.pont
            if (Physics.Raycast(mousePos, out RaycastHit hit1, 100f))
            {
                Instantiate(Effect, hit1.point, Quaternion.identity);
            }

            // hit.normal - ǥ�� ���� ��� (����Ʈ ����)
            if (Physics.Raycast(mousePos, out RaycastHit hit2, 100f))
            {
                Quaternion rot = Quaternion.LookRotation(hit2.normal); // ǥ���� ���ϴ� ����
                Instantiate(normalEffect, hit2.point, Quaternion.identity);
            }

            // distance - ���� ���������� �Ÿ� Ȯ��
            if (Physics.Raycast(mousePos, out RaycastHit hit3, 100f))
            {
                Debug.Log("�浹���� �Ÿ� :" + hit3.distance);
            }

            // transform
            if (Physics.Raycast(mousePos, out RaycastHit hit4, 100f))
            {
                hit3.transform.Rotate(Vector3.up * 10f); // �浹�� ���������� -X������ 90ȸ��
            }
        }
        
    }
}
