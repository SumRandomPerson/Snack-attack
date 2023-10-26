using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 10f;
    private float turnSpeed = 10f;
    private float horizontalInput; 
    private float fowardInput; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        fowardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * fowardInput);
        transform.Translate(Vector3.right * turnSpeed * horizontalInput * Time.deltaTime);
    }
}

