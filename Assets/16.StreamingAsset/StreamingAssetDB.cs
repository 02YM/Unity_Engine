using UnityEngine;

// System.Serializable로 선언된 클래스는 Json 파일의 필드 이름과 정확히 일치하는 변수 이름을 사용해야 합니다.!
[System.Serializable]

public class StreamingAssetDB
{
    public string playerName;
    public int level;
    public float hp;
}