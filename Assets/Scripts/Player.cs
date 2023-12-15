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
    private AudioSource playerAudio;
    public AudioClip goodSound;
    public AudioClip badSound;
    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
   void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        fowardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * fowardInput);
        transform.Translate(Vector3.right * turnSpeed * horizontalInput * Time.deltaTime);
    }


private void OnTriggerEnter(Collider other) {
        
        if (other.gameObject.CompareTag("Point")){
           goodParticle.Play();
        playerAudio.PlayOneShot(goodSound, 1.0f);
        }
    else if (other.gameObject.CompareTag("Damage")){
    badParticle.Play();
playerAudio.PlayOneShot(badSound, 1.0f);
    }
}









}





