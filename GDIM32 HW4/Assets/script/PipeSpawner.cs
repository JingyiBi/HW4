using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
   public GameObject pipePrefab;
   public float spawnRate = 1f;
   public float heightOffset = 2f;
   private float timer = 0f;
    void Start()
    {
        SpawnPipe();
    }
   void Update()
    {
        if(Time.timeScale>0)
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0f;
        }}
        void SpawnPipe()
        {
            float lowestPoint = transform.position.y - heightOffset;
            float highestPoint = transform.position.y + heightOffset;
            
            Instantiate(pipePrefab, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
