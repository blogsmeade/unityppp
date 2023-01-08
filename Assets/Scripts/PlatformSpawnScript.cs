using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawnScript : MonoBehaviour
{
    public GameObject Platform;
    public GameObject PlatformRot;
    private int PinkJellyCouter;
    private int RandomRedJelly;
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
        RandomRedJelly = Random.Range(4, 12);
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
        if (PinkJellyCouter <= RandomRedJelly)
        {
            SpawnDistance = Random.Range(MinDistance, MaxDistance);
            Instantiate(Platform, new Vector3(Random.Range(MaxRight, MaxLeft), transform.position.y, 0), Quaternion.identity);
            lastSpawnPosition = transform.position.y;
            PinkJellyCouter += 1;
                 }
        else
        {
            SpawnDistance = Random.Range(MinDistance, MaxDistance);
            Instantiate(PlatformRot, new Vector3(Random.Range(MaxRight, MaxLeft), transform.position.y, 0), Quaternion.identity);
            lastSpawnPosition = transform.position.y;
            RandomRedJelly = Random.Range(4, 12);
            PinkJellyCouter =0;
        }
    }
}
