using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour
{
    [SerializeField] float delay = 1f;
    [SerializeField] ParticleSystem FinishEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            FinishEffect.Play(); 
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", delay);
        }
    }

         void ReloadScene()
        {
            SceneManager.LoadScene(0);
        }
}
