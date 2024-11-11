using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Game_Event : MonoBehaviour
{
    public static Game_Event instance;

    private void Awake()
    {
        instance = this;
    }

    public event Action OndoorTrigerEnter;
    public event Action OndoorTrigerLeave;

    public void DoorTriggerEnter()
    {
        if (OndoorTrigerEnter != null)
            OndoorTrigerEnter();
    }

    public void DoorTrigerExit()
    {
        if (OndoorTrigerLeave != null)
            OndoorTrigerLeave();
    }
}
