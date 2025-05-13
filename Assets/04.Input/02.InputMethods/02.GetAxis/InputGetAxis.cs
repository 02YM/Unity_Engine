using UnityEngine;

public class InputGetAxis : MonoBehaviour
{
    [Header("GetAxis")]
    public float GetAxisHorizontal;
    public float GetAxisVertical;

    [Header("GetAxisRaw")]
    public float GetAxisRawHorizontal;
    public float GetAxisRawVertical;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetAxisHorizontal = Input.GetAxis("Horizontal");
        GetAxisVertical = Input.GetAxis("Vertical");

        GetAxisRawHorizontal = Input.GetAxisRaw("Horizontal");
        GetAxisRawVertical = Input.GetAxisRaw("Vertical");        
    }
}
