using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    public Rigidbody2D Circle;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBomb", 1.0f, 2f);
    }
    void SpawnBomb()
    {
        int i = Random.Range(-2, 3);
        Rigidbody2D instance = Instantiate(Circle, transform);
        instance.velocity = Vector2.down * 1f;
        instance.transform.position = instance.transform.position + Vector3.right * i;
    }

 
}
