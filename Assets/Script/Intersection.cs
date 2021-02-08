using System.Collections;
using UnityEngine;

public class Intersection : MonoBehaviour
{
    public int carsInIntersection = 0;
    public ArrayList arrCarsInIntersection = new ArrayList();
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        carsInIntersection++;
        //arrCarsInIntersection.Add(collision.gameObject.GetComponent<CreateCars>().car);
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        carsInIntersection--;
        //arrCarsInIntersection.Remove(collision.gameObject.GetComponent<CreateCars>().car);
    }
}
