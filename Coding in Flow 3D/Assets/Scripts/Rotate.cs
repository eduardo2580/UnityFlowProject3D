using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    [SerializeField] float speedX;
    [SerializeField] float speedY;
    [SerializeField] float speedZ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(360 * speedX * Time.deltaTime, 360 * speedY * Time.deltaTime, 360 * speedZ * Time.deltaTime);
    }
}
