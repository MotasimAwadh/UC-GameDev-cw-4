using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //public GameObject namesisObject;
    public GameObject enemyObject;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawn()
    {
        GameObject spawnObject = enemyObject;
        int newPosition = Random.Range(-1, 2);
        Vector3 vPosition = transform.position;
        vPosition.x = vPosition.x + (3 * newPosition);
        //GameObject newSpawn = Instantiate(spawnObject,vPosition,Quaternion.identity);
        GameObject newSpawn = Instantiate(spawnObject);
        newSpawn.transform.position = vPosition;
    }
}
