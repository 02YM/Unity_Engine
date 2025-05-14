using UnityEngine;

public class ResourcesUnloadAsset : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Texture2D tex;

    void Start()
    {
        tex = Resources.Load<Texture2D>("Texture/Map");        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
            Resources.UnloadAsset(tex);
    }
}
