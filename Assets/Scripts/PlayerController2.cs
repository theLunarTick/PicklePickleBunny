using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController2 : MonoBehaviour
{
    FartControl splatter;
    Vector2 movein;
    public float hustle = 10;

    private void Awake()
    { 
        splatter = new FartControl();
        splatter.Barffer.FartMove.performed += ctx => SendMessage(ctx.ReadValue<Vector2>());

        splatter.Barffer.FartMove.performed += ctx => movein = ctx.ReadValue<Vector2>();

        splatter.Barffer.FartMove.canceled += ctx => movein = Vector2.zero;
    }


private void OnEnable()
    {
        splatter.Barffer.Enable();
    }

    private void OnDisable()
    {
        splatter.Barffer.Disable();
    }

    void SendMessage(Vector2 coordinates)
    {
        Debug.Log("Thumb-stick coordinates = " + coordinates);
    }

    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(movein.x, movein.y) * hustle * Time.deltaTime;
        transform.Translate(movement, Space.World);
    }
}
