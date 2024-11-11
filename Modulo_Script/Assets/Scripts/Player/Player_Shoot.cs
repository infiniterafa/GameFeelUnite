using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Player_Shoot : MonoBehaviour
{
    public CameraManager camerachida;
    public float Bullets = 9;
    public

    void Start()
    {

    }

    // se cambio la forma en la que las balas se disparan para que el jugador no llegue a -1 balas con la funcion clamp

    void Update()
    {
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0) && GameManager.Instance.Bullets > 0)
        {
            GameManager.Instance.Bullets--;
            GameManager.Instance.Bullets = Mathf.Clamp(GameManager.Instance.Bullets, 0, 9);
            GameManager.Instance.AmmoBullets();
            
           camerachida.HitShake();

            if (Physics.Raycast(transform.position,
                transform.TransformDirection(Vector3.forward), out hit, 1000))
            {
                Debug.DrawRay(transform.position, transform.
                TransformDirection(Vector3.forward) * hit.distance, Color.red);

                print(hit.transform.name);

                if (hit.transform.CompareTag("Enemy"))
                {
                    hit.transform.parent.GetComponent<Norm_Ene_Move>().EnemyLifes -= 5;
                }
            }
        }
    }
}
