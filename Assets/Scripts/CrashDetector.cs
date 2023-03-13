using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 0.5f;
    [SerializeField] ParticleSystem deathEffect;
    [SerializeField] AudioClip crashSFX;
    bool dead;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ground" && !dead)
        {
            dead = false;
            FindObjectOfType<PlayerController>().DisableControls();
            deathEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", loadDelay);
        }    
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
