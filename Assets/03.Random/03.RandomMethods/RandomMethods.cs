using UnityEngine;

public class RandomMethods : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        // 무작위 시드 설정
        Random.InitState(42);

        for(int i= 0; i< 5; i++)
        {
            // 1. 무작위 위치 생성( x:-5 ~ 5, z:-5 ~ 5)
            Vector3 randomPos = new Vector3(Random.Range(-5f, 5f), 0, Random.Range(-5f, 5f));

            // 2. 무작위 색상 생성(HSV)
            Color randomColor = Random.ColorHSV();

            // 3. 프리팹 생성
            GameObject obj = Instantiate(prefab, randomPos, Quaternion.identity);

            // 4. 색상 적용
            obj.GetComponent<Renderer>().material.color = randomColor;
        }

    }
}
