using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private BallProjectile _ballProjectile;

    private void Awake()
    {
        GameManager.OnInGame += MovetoPosition;
    }

    // Start is called before the first frame update
    void Start()
    {
        _ballProjectile = FindObjectOfType<BallProjectile>();
    }

    //move to position where the ball dropped on threshold
    void MovetoPosition()
    {
        transform.position = _ballProjectile.ballPos.position;
    }
}
