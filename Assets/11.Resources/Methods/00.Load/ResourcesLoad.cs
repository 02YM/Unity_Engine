using UnityEngine;

public class ResourcesLoad : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject enemyPrefab = Resources.Load<GameObject>("Prefabs/Enemy");
        Instantiate(enemyPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
