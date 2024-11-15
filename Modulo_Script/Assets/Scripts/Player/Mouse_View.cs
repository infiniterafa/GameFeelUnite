using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Mouse_View : MonoBehaviour
{
    public float MouseSens = 1000f;

    public Transform Player, Camera;
    float xRotation = 0f;
    private CameraManager cameraManager;

    private void Start()
    {
        cameraManager = CameraManager.Instance;

        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float MouseX = Input.GetAxis("Mouse X") * MouseSens * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * MouseSens * Time.deltaTime;

        xRotation -= MouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);


        //Rotar la cámara que la variable referencia, en lugar de usar transform, que hace referencia al tranform del script
        Camera.localRotation = Quaternion.Euler(xRotation, 0, 0);
        Player.Rotate(Vector3.up, MouseX);

        //transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        //Player.Rotate(Vector3.up * MouseX);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Enemy"))
        {
            cameraManager.HitShake();
        }
    }
}
