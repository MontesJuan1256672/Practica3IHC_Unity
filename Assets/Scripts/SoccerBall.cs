using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerBall : Interactable
{
    private Rigidbody rb;
    public Vector3 direction;
    public float kickForce = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    protected override void Interac()
    {
        base.Interac();
        rb.AddForce(direction * kickForce);
    }
}
