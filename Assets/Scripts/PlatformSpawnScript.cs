using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawnScript : MonoBehaviour
{
    public GameObject Platform;
    private float SpawnDist;
    private float lastspawn;
    [Header("Vertikale Abstände Platformen")]
    [SerializeField]
    private float MaxDist = 2.6f;
    [SerializeField]
    private float MinDist = 1.2f;
    [Header("Horizontale Abstände Platformen")]
    [SerializeField]
    private float MaxLinks = -2.3f;
    [SerializeField]
    private float MaxRechts = 2.3f;
    // Start is called before the first frame update
    void Start()
    {
        lastspawn = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(lastspawn+SpawnDist<transform.position.y)
        {
            SpawnDist = Random.Range(MinDist, MaxDist);
            Instantiate(Platform, new Vector3(Random.Range(MaxRechts, MaxLinks), transform.position.y,0), transform.rotation);
            lastspawn = transform.position.y;

        }
        

    }
}
