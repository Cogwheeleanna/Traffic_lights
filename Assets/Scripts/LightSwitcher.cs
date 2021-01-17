using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitcher : MonoBehaviour
{
    //поля для лампочек светофора
    [SerializeField] private TrafficLightsController redLight;
    [SerializeField] private TrafficLightsController yellowLight;
    [SerializeField] private TrafficLightsController greenLight;

    //поля для контроля скорости переключения лампочек
    [SerializeField] float RedLightTimer;
    [SerializeField] float YellowLightTimer;
    [SerializeField] float GreenLightTimer;

    //Переключение лампочек по таймерам
    public void Start()
    {
        StartCoroutine(switcher());
    }

    IEnumerator switcher ()
    {
        while (true)
        {
            GetRedOn();
            yield return new WaitForSeconds(RedLightTimer);

            GetYellowOn();
            yield return new WaitForSeconds(YellowLightTimer);

            GetGreenOn();
            yield return new WaitForSeconds(GreenLightTimer);

            GetYellowOn();
            yield return new WaitForSeconds(YellowLightTimer);
        }
        
    }
    //Структура переключения лампочек светофора
    public void GetRedOn()
    {
        redLight. TurnOn();

        yellowLight.TurnOff();
        greenLight.TurnOff();
        Debug.Log("Горит красный свет");
    }

    public void GetYellowOn()
    {
        yellowLight.TurnOn();

        redLight.TurnOff();
        greenLight.TurnOff();
        Debug.Log("Горит желтый свет");
    }

    public void GetGreenOn()
    {
        greenLight.TurnOn();

        redLight.TurnOff();
        yellowLight.TurnOff();
        Debug.Log("Горит зеленый свет");
    }
}
