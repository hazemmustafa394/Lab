using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectHeart : MonoBehaviour
{

    public AudioClip heartSound;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
          
            AudioManager.Instance.PlayMusicSFX(heartSound);
        
            Debug.Log("Has Heart: " + PlayerStats.hasHeart);
            Destroy(gameObject);
        }
    }
}