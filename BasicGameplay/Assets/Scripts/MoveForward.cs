using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;
    void Start()
    {
        
    }

    // Update is called once per frame

    // Destroy Out of Bounds
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);

        }
        if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            // GAME OVER

        }
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
