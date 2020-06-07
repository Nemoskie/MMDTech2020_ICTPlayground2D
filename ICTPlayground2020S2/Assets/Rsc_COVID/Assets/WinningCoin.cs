using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinningCoin : MonoBehaviour
{
    public AudioSource WinningSound;
    void OnTriggerEnter(Collider collider)
    {
        SceneManager.LoadScene("WinningScene");

    }
}
