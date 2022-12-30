using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeDog : Dog // Inheritance
{
    public override void moveForward(float speed) // Polymorphism
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed * 1.8f);
    }

    void Update()
    {
        if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            Debug.LogWarning("1 dog has lived!");

        }

        moveForward(speed);

    }
}
