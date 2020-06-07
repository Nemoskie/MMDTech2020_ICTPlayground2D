using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Scoretxt;
    public static int point;

    // Update is called once per frame
    void Update()
    {
        Scoretxt.GetComponent<Text>().text = "Score: " + point;
    }
}
