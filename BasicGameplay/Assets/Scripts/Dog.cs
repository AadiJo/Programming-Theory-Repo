using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{

    public float speed;

    [System.NonSerialized] public float lowerBound = -10.0f;

    public virtual void moveForward(float speed)
    {

        transform.Translate(Vector3.forward * Time.deltaTime * speed);

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
