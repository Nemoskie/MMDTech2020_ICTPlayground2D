using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorDamage : MonoBehaviour
{
    public AudioSource DamagedSound;

    void OnTriggerEnter(Collider other)
    {
        --HPBar.Health;
        DamagedSound.Play();
    }



}
