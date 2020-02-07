using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class CarAccel : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool isPressed = false;
    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;

    }

    private void FixedUpdate()
    {
        if (isPressed && !GlobalSwitchState.isPaused)
            GlobalSwitchState.rb.velocity += GlobalSwitchState.car.transform.forward * 1.0f;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }
}
