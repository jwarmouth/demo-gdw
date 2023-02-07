using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] objects;
    public Transform[] locations;
    public float minDelay;
    public float maxDelay;
    public float delay;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnObject", delay);
    }

    // Update is called once per frame
    void SpawnObject()
    {
        int whichObject = Random.Range(0, objects.Length);
        int whichLoc = Random.Range(0, locations.Length);
        Instantiate(objects[whichObject], locations[whichLoc].position, Quaternion.identity);
        delay = Random.Range(minDelay, maxDelay);
        Invoke("SpawnObject", delay);
    }
}
