﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle2D : MonoBehaviour
{

    //Step 1
    public Vector2 position;
    public Vector2 velocity;
    public Vector2 acceleration;


    //Step 2
    void updatePositionEulerExplicit(float dt)
    {
        // x(t+dt) = x(t) + v(t)dt

        //Euler's Method:
        // F(t+dt) = F(t) + f(t)dt
        //                  +(dF/dt)dt

        position += velocity * dt;

        //v(t+dt) = v(t) * a(t)dt

        velocity += acceleration * dt;
    }

    void updateRotationEulerExplicit(float dt)
    {

    }

    void updatePositionKinematic(float dt)
    {
        position += (velocity * dt) + 1/2 * acceleration * dt * dt;

        velocity += acceleration * dt;
    }

    void updateRoationKinematic(float dt)
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Step 3
        //updatePositionEulerExplicit(Time.fixedDeltaTime);
        updatePositionKinematic(Time.fixedDeltaTime);
        transform.position = position;

        //Step 4: test
        acceleration.x = -Mathf.Sin(Time.fixedTime); 
    }
}
