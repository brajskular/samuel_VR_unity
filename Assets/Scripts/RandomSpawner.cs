using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public int numberOfCubes = 3;
    public float spawnCollisionCheckRadius = 0.5f;
    public LayerMask obstacleLayer = 1 << LayerMask.NameToLayer("Obstacle");
    // import plane
    public GameObject plane;

    // Start is called before the first frame update
    void Start()
    {
        // get plane x and z dimensions
        float planeX = plane.transform.localScale.x;
        float planeZ = plane.transform.localScale.z;

        Vector3 randomSpawnPosition;
        for (int i = 0; i < numberOfCubes; i++)
        {
            //randomSpawnPosition = new Vector3(Random.Range(-planeX, planeX), 1, Random.Range(-planeZ, planeZ));
            randomSpawnPosition = new Vector3(Random.Range(-10, 10), 1, Random.Range(-10, 10));
            if(!Physics.CheckSphere(randomSpawnPosition, spawnCollisionCheckRadius, obstacleLayer))
            {
                Instantiate(cubePrefab, randomSpawnPosition, Quaternion.identity);
            }
            else
            {
                numberOfCubes++;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
