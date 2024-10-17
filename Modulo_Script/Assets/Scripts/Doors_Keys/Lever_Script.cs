using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever_Script : MonoBehaviour
{

    void Start()
    {
        Game_Event.instance.OndoorTrigerEnter += OnDoorMove;
        Game_Event.instance.OndoorTrigerLeave += OnDoorOut;
    }

    private void OnDestroy()
    {
        Game_Event.instance.OndoorTrigerEnter -= OnDoorMove;
        Game_Event.instance.OndoorTrigerLeave -= OnDoorOut;
    }

    void OnDoorMove()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(10.024f, 5.82f, 2.205f), 1);
    }
    void OnDoorOut()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(10.024f, 2.23f, 2.205f), 1);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Game_Event.instance.DoorTriggerEnter(); print("Hola");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Game_Event.instance.DoorTrigerExit();
        }
    }
}
