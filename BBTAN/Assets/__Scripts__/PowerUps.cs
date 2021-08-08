using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    private BlockController _blockController;
    private BallProjectile _ballProjectile;

    private GameObject parent1;

    private void Awake()
    {
        _ballProjectile = FindObjectOfType<BallProjectile>();
        _blockController = FindObjectOfType<BlockController>();
        
        parent1 = GameObject.FindWithTag("parent");
    }

    void PowerUp1()
    {
        if (_blockController.counter == 0)
        {
            //destroy row1
            parent1.SetActive(false);
        }
    }
    void PowerUp2()
    {
        if (_blockController.counter == 0)
        {
            //multiply and explode?
        }
    }
    //onclick --- faster projectile for 3 secs
    void PowerUp3()
    {
        _ballProjectile.force = Vector2.one * 3f;
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        _ballProjectile.force = Vector2.one;
        
        yield return new WaitForSeconds(3f);
    }
}
