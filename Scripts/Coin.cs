using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D other){
        Destroy(gameObject);

    }
}
