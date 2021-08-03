using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject[] platformPrefabs;
    public int platformSpawnCount;
    public Vector3 lastEndPoint;

    public void SpawnPlatform()
    {
        for (int i = 0; i < platformSpawnCount; i++)
        {
            GameObject platform = GameObject.Instantiate(platformPrefabs[Random.Range(0,platformPrefabs.Length)]);
            Platform platformScript = platform.GetComponent<Platform>();

            platform.transform.position = lastEndPoint;
            lastEndPoint = platformScript.ReturnEndPoint();
        }
    }

    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        SpawnPlatform();
    }

    private void FixedUpdate()
    {
        
    }
}
