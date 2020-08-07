using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBullet : MonoBehaviour
{

    public GameObject newBullet;
    public float timeBeforeNextBullet = 5;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnNext", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnNext()
    {
        GameObject newIteration = Instantiate(newBullet);
        newBullet.transform.position = new Vector2(transform.position.x, transform.position.y);
        Invoke("SpawnNext", timeBeforeNextBullet);
    }
}
