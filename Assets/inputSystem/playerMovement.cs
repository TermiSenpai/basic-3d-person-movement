using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    float playerSpeed = 10f;
    bool isAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMovement()
    {
        if (isAlive)
        {
            transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime);
        }
    }
}
