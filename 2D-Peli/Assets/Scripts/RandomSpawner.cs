using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public Transform[] spawnpoints;
    public GameObject item;

    public float timeBetweenSpawns = 45f;
    public float spawnCountdown;

    private void Start()
    {
        spawnCountdown = timeBetweenSpawns;
    }

    private void Update()
    {

        if (Health.dead)
        {
            return; 
        }

        if (spawnCountdown <= 0)
        {
            SpawnItem();
            spawnCountdown = timeBetweenSpawns;
        }
        else
        {
            spawnCountdown -= Time.deltaTime;
        }
    }

    void SpawnItem()
    {
        Transform _sp = spawnpoints[Random.Range(0, spawnpoints.Length)];
        Instantiate(item, _sp.position, _sp.rotation);
    }
}
