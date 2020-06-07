using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagedObject : MonoBehaviour
{

    public AudioSource DamagedSound;
    void OnTriggerEnter(Collider other)
    {
        HPBar.Health -= 1;
        DamagedSound.Play();
    }
}
