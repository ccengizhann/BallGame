using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotateSpeed;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.Rotate(0, rotateSpeed, 0);
    }
}
