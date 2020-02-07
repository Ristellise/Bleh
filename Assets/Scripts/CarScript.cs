using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    Vector3 velocity;
    public float speed = 0.1F;
    public float rot = 0.0F;
    public float rotDrag = 1.5F;
    // Start is called before the first frame update
    void Start()
    {
        GlobalSwitchState.car = gameObject;
        GlobalSwitchState.rb = GetComponent<Rigidbody>();
        SphereFollower sp = (SphereFollower)gameObject.transform.Find("/Sphere").gameObject.GetComponent(Type.GetType("SphereFollower"));
        Debug.Log(sp);
        sp.setLeader(gameObject.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    void FixedUpdate()
    {
        
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        //Debug.Log(GlobalSwitchState.isPaused);
        if (GlobalSwitchState.isPaused)
            return;
        if (Input.GetKey("w") || Input.GetKey("s"))
        {
            GlobalSwitchState.rb.velocity += GlobalSwitchState.car.transform.forward * Vertical;
        }
        if (Input.GetKey("a") || Input.GetKey("d"))
        {
            rot += Horizontal;
            //velocity += transform.right * -speed;
        }

        if (rot > 0.0F || rot < 0.0F)
            GlobalSwitchState.rb.MoveRotation(GlobalSwitchState.rb.rotation * Quaternion.Euler(0, rot, 0));
        rot = (Mathf.Lerp(rot, 0.0F, Time.fixedDeltaTime) * GlobalSwitchState.rb.mass) / rotDrag;
        //velocity += velocity *(-(rb.mass * Time.fixedDeltaTime));
    }
}
