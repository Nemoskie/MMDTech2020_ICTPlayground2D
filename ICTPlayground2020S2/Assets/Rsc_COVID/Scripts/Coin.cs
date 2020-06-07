using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

   
    void OnTriggerEnter(Collider collider)
    {
        if (!collider.CompareTag("Player"))
        {
            return;
        }
        ++PlayerUnit.CoinsCollected;
        Destroy(gameObject);
    }
}
