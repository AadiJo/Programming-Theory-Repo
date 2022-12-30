using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackDog : Dog // Inheritance
{
    // Start is called before the first frame update
    public override void moveForward(float speed) // Polymorphism
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed * 1.2f);
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
