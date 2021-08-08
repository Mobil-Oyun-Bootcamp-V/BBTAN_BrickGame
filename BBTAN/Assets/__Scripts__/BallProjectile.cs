using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallProjectile : MonoBehaviour
{
    private Rigidbody2D rigi;
    public Transform ballPos { get; private set; }

    public Vector2 force;
    private void Awake()
    {
        GameManager.OnInGame += BallForce;
    }

    void Start()
    {
        force =Vector2.one;
        
        rigi = gameObject.GetComponent<Rigidbody2D>();
    }

    //Move ball
    public void BallForce()
    {
        rigi.AddForce(force);
    }
    
    //destroy and save after ball is beyond threshold

    private void OnTriggerExit(Collider other)
    {
        //change ball-player pos
        ballPos.position = transform.position ;
        if (other.CompareTag("threshold"))
        {
            Destroy(gameObject);
        }
    }
}
