using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb_spawner : MonoBehaviour
{

    public GameObject itemPrefab; //gameobject variable

    //public float r; //radius
    public float spawnTimer;
    public float initialSpawnInterval = 1f;
    public float minimumInterval = 0.05f;
    float randomX;
    float randomY;
    int counter;


    // Start is called before the first frame update
    void Start()
    {
        //for(int i = 0; i < 10; i++)
        //{
        //  spawnObject();
        //}
        spawnTimer = initialSpawnInterval;
        counter = 0;

    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0f)
        {
            spawnObject();
            spawnTimer = initialSpawnInterval;
            counter += 1;
            if (counter >= 15)
            {
                spawnTimer = Mathf.Max(minimumInterval, initialSpawnInterval - 0.1f);
                initialSpawnInterval = spawnTimer;
                counter = 0;
            }
        }

    }
    //tell unity how to create bombs
    void spawnObject()
    {
        randomX = Random.Range(-3f, 3f);
        randomY = Random.Range(3f, 4f);
        Vector3 randomPos = new Vector3(randomX, randomY, 0f); //Random.insiRadeUnitCircle * r; //position random x, y within radius of this circle
        Instantiate(itemPrefab, randomPos, Quaternion.identity); //3 elements; what object?, which position?, Quat.identity // rotation to spawn at
    }
}