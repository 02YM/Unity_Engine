using UnityEngine;

public class InputGetKey : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Debug.Log("GetKey Space");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("GetKeyDown Space");
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("GetKeyUp Space");
        }
    }
}
