using UnityEngine;
using UnityEngine.InputSystem;

// ����Ƽ ���� �����ϴ� �⺻ InputSystem_Action�� ����մϴ�.
//

public class InputGetButton : MonoBehaviour
{

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if((Input.GetButton("Jump")))
        {
            Debug.Log("GetButton");
        }

        if ((Input.GetButtonDown("Jump")))
        {
            Debug.Log("GetButtonDown");
        }

    }
}
