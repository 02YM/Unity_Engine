using UnityEngine;

// ����ȭ�� ���� ���ʹϾ� ��ȯ

public class QuaternionNormalize : MonoBehaviour
{    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Quaternion q = new Quaternion(0, 180, 0, 90);
        Quaternion normalized = Quaternion.Normalize(q);        

        transform.rotation = normalized;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
