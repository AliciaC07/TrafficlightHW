using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float velocity = 0;
    private bool visible = false;
    public GameObject trafficLight;
    private GameObject car = null;

    void Start()
    {
        if (trafficLight.GetComponent<TrafficLight>().stop == true)
        {
            velocity = 3;
        }
        //else if (trafficLight.GetComponent<TrafficLight>().yellowLigth == true)
        //{
        //    velocity = 7;
        //}
        else
        {
            velocity = 5;
        }
        gameObject.transform.Translate(new Vector2(0, -velocity * Time.deltaTime));
        

    }


    void Update()
    {

        

        gameObject.transform.Translate(new Vector2(0, -velocity * Time.deltaTime));

        

    }

    private void OnBecameInvisible()
    {
        if (visible)
        {
            GameObject.Destroy(gameObject);

        }

    }

    private void OnBecameVisible()
    {
        visible = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (car == null)
        {
            velocity = 0;
            car = collision.gameObject;
        }
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject == car)
        {
            velocity = 5;
        }
        
    }
}
