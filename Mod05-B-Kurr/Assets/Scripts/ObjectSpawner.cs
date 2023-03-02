using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ObjectSpawner : MonoBehaviour
{
    public static List<GameObject> spawns = new List<GameObject>();
    public GameObject spawnObject1;
    public GameObject spawnObject2;
    public GameObject spawnObject3;
    public GameObject spawnObject4;
    int randomNumber;


    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(spawnObject);
        //public GameObject[] = new GameObject[spawnObject1, spawnObject2, spawnObject3, spawnObject4];
        spawns.Add(spawnObject1);
        spawns.Add(spawnObject2);
        spawns.Add(spawnObject3);
        spawns.Add(spawnObject4);
        
    }

    // Update is called once per frame
    void Update()
    {
        //Instantiate(spawnObject);
        GameObject go1 = Instantiate<GameObject>(spawns[randomNumber = UnityEngine.Random.Range(0, 3)]);
        Material mat = go1.GetComponent<Renderer>().material;
        mat.color = UnityEngine.Random.ColorHSV(0, 1, 0.5f, 1, 0.75f, 1);

       
    }
}
