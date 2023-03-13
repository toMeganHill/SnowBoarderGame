using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem snowEffect;
   
   void OnCollisionEnter2D(Collision2D other) 
   {
        if(other.gameObject.tag == "Ground")
        {
            snowEffect.Play();
        }   
   }
   
   void OnCollisionExit2D(Collision2D other) 
   {
        if(other.gameObject.tag == "Ground")
        {
            snowEffect.Stop();
        }   
   }
        
    
}
