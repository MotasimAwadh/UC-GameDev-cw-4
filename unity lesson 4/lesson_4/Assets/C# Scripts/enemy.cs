using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed;
    Rigidbody rBody;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;
        rBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rBody.velocity = new Vector3(0, 0, -speed);
    }
    
}
