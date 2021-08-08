using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static event System.Action OnPreGame;
    public static event System.Action OnInGame;

    private int activeBallCount;
    
    public enum State
    {
        PreGame , InGame
    }
    public static State currentState { get; private set; }

    private void Update()
    {
        switch (currentState)
        {
            case(State.PreGame):
                OnPreGame.Invoke();
                break;
            case(State.InGame):
                OnInGame.Invoke();
                break;
        }
        //STATE OF THE GAME DEPENDS ON 1 THİNG =>=> ACTIVE PROJECTILE BALLS AVAILABLE ON THE SCENE
        if (activeBallCount == 0)
        {
            SetState("PreGame");
        }
        else
        {
            SetState("InGame");
        }
    }
    public static State GetState(string get)
    {
        switch (get)
        {
            case "PreGame":
                return State.PreGame;
                
            case "Ingame":
                return State.InGame;
            
            default:
                return State.PreGame;
        }
        
    }
    public static void SetState(string set)
    {
        switch (set)
        {
            case "PreGame":
                currentState = State.PreGame;
                break;

            case "InGame":
                currentState = State.InGame;
                break;
        }
    }
}
