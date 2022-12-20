using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawnScript : MonoBehaviour
{
    public GameObject Platform;
    private float SpawnDistance;
    private float lastSpawnPosition;
    [Header("Vertikale Abstände Platformen")]
    [SerializeField]
    private float MaxDistance = 2.4f;
    [SerializeField]
    private float MinDistance = 1.2f;
    [Header("Horizontale Abstände Platformen")]
    [SerializeField]
    private float MaxLeft = -2.15f;
    [SerializeField]
    private float MaxRight = 2.15f;
    // Start is called before the first frame update
    void Start()
    {
        lastSpawnPosition = transform.position.y;
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if(lastSpawnPosition+SpawnDistance<transform.position.y)
        {
            Spawn();
        }
        

    }
    private void Spawn()
    {
        SpawnDistance = Random.Range(MinDistance, MaxDistance);
        Instantiate(Platform, new Vector3(Random.Range(MaxRight, MaxLeft), transform.position.y, 0), Quaternion.identity);
        lastSpawnPosition = transform.position.y;
    }
}
