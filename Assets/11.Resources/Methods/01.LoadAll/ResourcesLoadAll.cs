using UnityEngine;

public class ResourcesLoadAll : MonoBehaviour
{
    public GameObject[] Effects;

    void Start()
    {
        GameObject[] effects = Resources.LoadAll<GameObject>("Effects");

        foreach(GameObject fx in effects)
        {
            Instantiate(fx);
        }
        Effects = effects;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
