using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingSOund : MonoBehaviour
{
    public AudioSource CollectedSound;
    void OnTriggerEnter(Collider collider)
    {
        if (!collider.CompareTag("Player"))
        {
            return;
        }

        CollectedSound.Play();

        
        
    }
}
