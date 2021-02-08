using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCars : MonoBehaviour
{
    public GameObject[] cars;
    public float timer = 3;
    public int index;
    public GameObject trafficLight;
    public GameObject car;
    private int countCar = 3;

    void Start()
    {

        index = Random.Range(0, 1);
        car = Instantiate(cars[index], gameObject.transform);
        car.GetComponent<CarMovement>().trafficLight = trafficLight;


    }


    void Update()
    {
        
        if (!trafficLight.GetComponent<TrafficLight>().stop)
        {
            
            timer -= 1 * Time.deltaTime;
            countCar = 3;
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

                car = Instantiate(cars[index], gameObject.transform);
                car.GetComponent<CarMovement>().trafficLight = trafficLight;
                timer = 4;
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

                    car = Instantiate(cars[index], gameObject.transform);
                    car.GetComponent<CarMovement>().trafficLight = trafficLight;
                    timer = 4;
                    countCar--;
                    
                }
                

            }
        }
        
    }
}