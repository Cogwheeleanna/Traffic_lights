using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Переключает цвета светофора

public class TrafficLightsController : MonoBehaviour
{
    
    //Поля, которые позволяют присвоить цвет лампочкам светофора
    [SerializeField] Material onLight;
    [SerializeField] Material offLight;


    private Renderer lightsRenderer;

    private void Awake()
    {
        lightsRenderer = GetComponent<Renderer>();

        TurnOff();
    }

    public void TurnOn()
    {
        lightsRenderer.material = onLight;
    }
    public void TurnOff()
    {
        lightsRenderer.material = offLight ;

    }
   

}
