using UnityEngine;

public class InputGetMouseButton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Debug.Log("GetMouseButton");
        }

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("GetMouseButtonDown");
        }

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("GetMouseButtonUp");
        }
    }
}
