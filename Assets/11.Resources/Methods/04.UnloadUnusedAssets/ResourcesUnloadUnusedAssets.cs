using System.Collections;
using UnityEngine;

// ������ ���� ������, �� ��ȯ �Ҷ� ����ϸ� �����ϴ�.

public class ResourcesUnloadUnusedAssets : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 num = new Vector3(Random.Range(-2, 2), 0, 0);
            GameObject Enemy = Resources.Load<GameObject>("Prefabs/Enemy");
            Instantiate(Enemy, num, Quaternion.identity);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(ClearResources());
        }
    }

    IEnumerator ClearResources()
    {
        yield return Resources.UnloadUnusedAssets();
        Debug.Log("Unsed assets unloaded"); ;
    }
}
