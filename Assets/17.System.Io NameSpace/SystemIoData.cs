using System;
using UnityEngine;

// ���� �ý��ۿ��� ����ȭ Ȱ �� �ֵ��� ǥ���Դϴ�.
// Unity�� JsonUtility�� Inspector ���� �ý����� �� Ŭ������ �ϰ� ���� �����ϰ� ����ϴ�.

/*
 *  ����ȭ��?
 *  ��ü -> ������(���ڿ�, ���̳ʸ� ��)�� ��ȯ�ϴ� �����Դϴ�.
 *   Unity������ ���� ���� 2���� ���·� ����ȭ�˴ϴ�.
 *   Inspector���� �����ֱ� ����
 *   JsonUtilty.ToJson()�� ���� Json���ڿ��� ��ȯ�ϱ� ����
 */
[System.Serializable]
public class SystemIoData
{
    public string playerName;
    public int level;
    public float hp;
}
