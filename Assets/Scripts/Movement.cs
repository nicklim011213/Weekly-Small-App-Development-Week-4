using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody body;
    public float speed = 700;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        body.AddForce(body.transform.forward * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
        {
            body.AddForce(-body.transform.right * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            body.AddForce(body.transform.right * speed * Time.deltaTime);
        }
    }
}
