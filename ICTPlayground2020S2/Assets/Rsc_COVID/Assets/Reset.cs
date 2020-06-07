using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        HPBar.Health = HPBar.MaxHp;
        Score.point = 0;
        SceneManager.LoadScene("SampleScene");
    }

   
}
