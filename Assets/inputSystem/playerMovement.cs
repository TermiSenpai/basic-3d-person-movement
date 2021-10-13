using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{
    CharacterController controller;
    InputManager playerInput;

    float playerSpeed = 10f;
    bool isAlive = true;

    // Start is called before the first frame update
    private void Awake()
    {
        playerInput.Player.Movement.performed += _ => move();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMovement()
    {

    }

    void move()
    {
        Debug.Log("moveeee!");
    }
}
