using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Endtile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            var movement = other.gameObject.GetComponent<Movement>();
            movement.speed = 0;
        }
        other.gameObject.GetComponentInChildren<Canvas>().GetComponent<TextMeshPro>().text = "Score: " + other.gameObject.GetComponent<CloneHandler>().clones.ToString();
        other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}
