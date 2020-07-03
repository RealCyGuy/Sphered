using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject thingToSpawn;

    [SerializeField]
    float spawnTime;

    float fTimer;

    void Start()
    {
        fTimer = spawnTime;
    }

    void Update()
    {
        fTimer -= Time.deltaTime;
        if (fTimer <= 0)
        {
            fTimer = spawnTime;

            Vector3 v3SpawnPos = transform.position;
            v3SpawnPos += Vector3.right * 10 * (Random.value - 0.5f);
            v3SpawnPos += Vector3.forward * 30 * (Random.value - 0.5f);

            Instantiate(thingToSpawn, v3SpawnPos, Quaternion.Euler(new Vector3(Random.Range(0, 360), 0, Random.Range(0, 360))));
        }
    }
}
