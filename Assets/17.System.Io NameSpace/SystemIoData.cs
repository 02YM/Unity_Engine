using System;
using UnityEngine;

// 내부 시스템에서 직렬화 활 수 있도록 표시입니다.
// Unity의 JsonUtility나 Inspector 같은 시스템이 이 클래스를 일고 쓰기 가능하게 만듭니다.

/*
 *  직렬화란?
 *  객체 -> 데이터(문자열, 바이너리 등)로 변환하는 과정입니다.
 *   Unity에서는 보통 다음 2가지 형태로 직렬화됩니다.
 *   Inspector에서 보여주기 위해
 *   JsonUtilty.ToJson()을 통해 Json문자열로 변환하기 위해
 */
[System.Serializable]
public class SystemIoData
{
    public string playerName;
    public int level;
    public float hp;
}
