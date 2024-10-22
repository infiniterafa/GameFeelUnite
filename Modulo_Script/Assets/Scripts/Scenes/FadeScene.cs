using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.UI; 

public class FadeScene : MonoBehaviour
{

    public TextMeshProUGUI introText; 
    // Start is called before the first frame update
    void Start()
    {
        Fade(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Fade()
    {
        introText.DOFade(0.0f, 5.0f);
        GetComponent<MeshRenderer>().material.DOFade(0.0f, 5.0f); 
    }
}
