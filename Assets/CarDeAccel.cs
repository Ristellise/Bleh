﻿using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class CarDeAccel : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool isPressed = false;
    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
        
    }

    private void FixedUpdate()
    {
        if (isPressed)
            GlobalSwitchState.rb.velocity += GlobalSwitchState.car.transform.forward * -1.0f;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }
}