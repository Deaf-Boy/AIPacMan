using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaenNodes : MonoBehaviour
{

    int SpawnAmount = 25;
    public float spawnoffset = 0.3f;
    public float Currentoffset;

    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.name == "Node")
        {
            Currentoffset = spawnoffset;
            for(int i = 0; i < SpawnAmount; i++)
            {
                //new node added
                GameObject clone = Instantiate(gameObject, new Vector3(transform.position.x + Currentoffset, transform.position.y, 0), Quaternion.identity);
                Currentoffset += spawnoffset;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
