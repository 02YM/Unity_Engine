using System.Collections;
using UnityEngine;

// Enemy 프리팹을 비동기 로드 요청
// 로딩이 완료 될때까지 대기
// GameObject로 캐스팅
// 씬에 프리팹 인스턴스 생성

// 핵심요약.
// 1 LoadAsync()                로딩이 시작됨, 아직 완료되지 않음
// 2 yield return requset       이 이후에야 실제로 로딩 완료
// 3 requset.asset 접근          yield 이후에 해야 정상 데이터 사용 가능


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
        //ResourcesRequset : 객체에 로드 진행 상태와 결과가 담깁니다.
        ResourceRequest request = Resources.LoadAsync<GameObject>("Prefabs/Enemy");
        yield return request;

        // requset.asset은 UnityEngine.Object 타입으로 GameObject로 캐스팅해야합니다.
        GameObject prefab = request.asset as GameObject;
        Instantiate(prefab);
    }
}
