using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    public float turnSpeed = 10f;
    public float horizontalInput; 
    public float fowardInput; 
    public int score = 0;
    public ParticleSystem badParticle;
    public ParticleSystem goodParticle;

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


private void OnCollisionEnter(Collision collision) {
        
        if (collision.gameObject.CompareTag("Point")){
           goodParticle.Play();
           
        }
    }










}





