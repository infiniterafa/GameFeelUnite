using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Key_Script : MonoBehaviour
{
    public UnityEvent PickKey;

    public void OnTriggerEnter(Collider other)
    {
        print(other.transform.name);
        if (other.transform.CompareTag("Player"))
        {
            if (GameManager.Instance.Keys < 20)
            {
                GameManager.Instance.Keys += 1;
                GameManager.Instance.KeysCount();
            }
            PickKey.Invoke();
        }
    }
}
