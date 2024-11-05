using System;
using UnityEngine;

public class BreakoutBallMovement : MonoBehaviour
{
    public Vector2 initialVelocity;
    private void Start()
    {
        GetComponent<Rigidbody2D>().velocity = initialVelocity;
    }
}