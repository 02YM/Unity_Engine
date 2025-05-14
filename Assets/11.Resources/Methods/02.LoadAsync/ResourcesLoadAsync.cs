using System.Collections;
using UnityEngine;

// Enemy �������� �񵿱� �ε� ��û
// �ε��� �Ϸ� �ɶ����� ���
// GameObject�� ĳ����
// ���� ������ �ν��Ͻ� ����

// �ٽɿ��.
// 1 LoadAsync()                �ε��� ���۵�, ���� �Ϸ���� ����
// 2 yield return requset       �� ���Ŀ��� ������ �ε� �Ϸ�
// 3 requset.asset ����          yield ���Ŀ� �ؾ� ���� ������ ��� ����


public class ResourcesLoadAsync : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Async());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Async()
    {
        //ResourcesRequset : ��ü�� �ε� ���� ���¿� ����� ���ϴ�.
        ResourceRequest request = Resources.LoadAsync<GameObject>("Prefabs/Enemy");
        yield return request;

        // requset.asset�� UnityEngine.Object Ÿ������ GameObject�� ĳ�����ؾ��մϴ�.
        GameObject prefab = request.asset as GameObject;
        Instantiate(prefab);
    }
}
