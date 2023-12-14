using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public int scoreToAdd;
     public ParticleSystem goodParticle;
    
    void OnTriggerEnter(Collider other)
   {
        if(other.CompareTag("Player"))
        {
            Player pc = other.GetComponent<Player>();
            pc.score += scoreToAdd;
            Debug.Log(pc.score);
            Destroy(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }


   
    
} 
}
