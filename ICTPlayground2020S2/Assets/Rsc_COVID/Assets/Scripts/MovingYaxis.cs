using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingYaxis : MonoBehaviour
{
    // Start is called before the first frame update


    public float rotateSpeed = 90f;
    public Vector3 rotateAxis = Vector3.zero;
    private Transform targetTransform = null;
    void Awake()
    {
        targetTransform = GetComponent<Transform>();
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        targetTransform.Rotate(new Vector3(
        rotateAxis.x * rotateSpeed *
        Time.deltaTime,
        rotateAxis.y * rotateSpeed *
        Time.deltaTime,
        rotateAxis.z * rotateSpeed *
        Time.deltaTime),
        Space.World);
    }
}
