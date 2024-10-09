using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveProjectile : MonoBehaviour
{

    public float speed = 35.0f;
    private float xRange = 30.0f;
    private float zRange = 30.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Projectile movement

        transform.Translate(Vector3.forward * Time.deltaTime * speed);


        // Boundaries for projectiles

        if (transform.position.x < -xRange)
        {

            Destroy(gameObject);

        }
        else if (transform.position.x > xRange)
        {

            Destroy(gameObject);

        }
        else if (transform.position.z < -zRange)
        {

            Destroy(gameObject);

        }
        else if (transform.position.z > zRange)
        {

            Destroy(gameObject);

        }


    }

    void OnTriggerEnter(Collider other)
    {

        Destroy(gameObject);

        Destroy(other.gameObject);

    }

}
