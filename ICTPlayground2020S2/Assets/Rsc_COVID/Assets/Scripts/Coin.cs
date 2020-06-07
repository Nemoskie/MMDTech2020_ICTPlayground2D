using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioSource CollectedSound;


    void OnTriggerEnter(Collider collider)
    {
        if (!collider.CompareTag("Player"))
        {
            return;
        }

        CollectedSound.Play();

        Score.point += 1;
        Destroy(gameObject);
    }
}
