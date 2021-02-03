using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCars : MonoBehaviour
{
    public GameObject[] car;
    public float timer = 2;
    public int index;
    public GameObject trafficLight;
    private int countCar = 3;

    void Start()
    {

        index = Random.Range(0, 1);
        Instantiate(car[index], gameObject.transform);


    }

    
    void Update()
    {
        if (!trafficLight.GetComponent<TrafficLight>().stop)
        {
            countCar = 3;
            timer -= 1 * Time.deltaTime;
            if (timer <= 0)
            {
                if (Random.Range(0, 10) >= 5)
                {
                    index = 1;
                }
                else
                {
                    index = 0;
                }

                Instantiate(car[index], gameObject.transform);
                timer = 2;
            }

        }
        else
        {
            if (countCar > 0)
            {
                timer -= 1 * Time.deltaTime;
                if (timer <= 0)
                {
                    if (Random.Range(0, 10) >= 5)
                    {
                        index = 1;
                    }
                    else
                    {
                        index = 0;
                    }

                    Instantiate(car[index], gameObject.transform);
                    timer = 2;
                    countCar--;
                }
                
                

            }
        }

       

    }
}
