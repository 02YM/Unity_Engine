using UnityEngine;

public class RandomMethods : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        // ������ �õ� ����
        Random.InitState(42);

        for(int i= 0; i< 5; i++)
        {
            // 1. ������ ��ġ ����( x:-5 ~ 5, z:-5 ~ 5)
            Vector3 randomPos = new Vector3(Random.Range(-5f, 5f), 0, Random.Range(-5f, 5f));

            // 2. ������ ���� ����(HSV)
            Color randomColor = Random.ColorHSV();

            // 3. ������ ����
            GameObject obj = Instantiate(prefab, randomPos, Quaternion.identity);

            // 4. ���� ����
            obj.GetComponent<Renderer>().material.color = randomColor;
        }

    }
}
