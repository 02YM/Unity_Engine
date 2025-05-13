using UnityEngine;
using UnityEngine.InputSystem;

// 유니티 에서 제공하는 기본 InputSystem_Action을 사용합니다.
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
