using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputTesting : MonoBehaviour
{

    public FartControl fartControl;

    private void Awake()
    {
        fartControl = new FartControl();
        // Vector2 movement = new movement.fartControl.Barffer.FartMove;
    }

    void Update()
    {
       // Debug.Log("klsls" + fartControl);
    }
}
