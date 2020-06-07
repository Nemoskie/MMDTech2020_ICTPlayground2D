using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnit : MonoBehaviour
{
    public static int CoinsCollected = 0;
    public static int CoinsToCollected = 0;

    public GameObject[] fireworks;

    void Awake()
    {
        CoinsToCollected =
            GameObject.FindGameObjectsWithTag("Coin").Length;
    }
    // Update is called once per frame
    void Update()
    {
        // Check coins collect
        if (CoinsCollected >= CoinsToCollected)
        {
            foreach (GameObject o in fireworks)
            {
                if (!o.activeSelf)
                { o.SetActive(true); }
            }
        }
    }
}
