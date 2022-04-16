using UnityEngine;
using System;

public class InputController 
{
    public Action InputESC;
    public float Horizontal;
    public float Vertical;

    public void Update() => CheckInput();

    private void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            InputESC?.Invoke();
        }

        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
    }
}
