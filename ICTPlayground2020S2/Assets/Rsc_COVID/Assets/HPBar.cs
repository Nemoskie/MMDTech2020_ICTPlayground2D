using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HPBar : MonoBehaviour
{
    public GameObject Healthtxt;
    public static int Health;
    public static int MaxHp = 5;




    // Start is called before the first frame update
    void Start()
    {
        Health = MaxHp;
    }

    // Update is called once per frame
    void Update()
    {

        if (Health <= 0)
        {
            Health = 0;
            SceneManager.LoadScene("GameOver");

        }
        Healthtxt.GetComponent<Text>().text = "Health: " + Health;
      
    }
}