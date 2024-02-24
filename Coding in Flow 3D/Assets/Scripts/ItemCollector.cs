using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    private int coins = 0;

    void Start()
    {
    }

    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            coins++;
            UnityEngine.Debug.Log("Coins collected: " + coins);
        }
    }
}

