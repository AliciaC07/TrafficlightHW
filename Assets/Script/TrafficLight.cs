﻿using System.Collections;
using UnityEngine;
using System.Threading.Tasks;

public class TrafficLight : MonoBehaviour
{
    public Sprite sprite_yellowlight;
    public Sprite sprite_redlight;
    public Sprite sprite_greenlight;
    public SpriteRenderer spriteRenderer;
    public GameObject intersection;
    public bool yellowLigth = false;
    //public float timer = 40;
    public bool trafficState = false; /// true-green false-red
    public bool stop = false;


    void Start()
    {

        StartCoroutine(TrafficsLigths());
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if (timer >= 20)
    //    {
    //        spriteRenderer.sprite = sprite_redlight;
    //        stop = true;

    //    }
    //    else if (timer >= 2.5f)
    //    {
    //        spriteRenderer.sprite = sprite_greenlight;
    //        stop = false;

    //    }
    //    else if (timer >= 0)
    //    {
    //        spriteRenderer.sprite = sprite_yellowlight;
    //        stop = true;

    //    }
    //    if (timer <= 0)
    //    {
    //        timer = 40;
    //    }
    //    timer -= Time.deltaTime;

    //}

    IEnumerator TrafficsLigths() {
        while (true)
        {
            if (!trafficState)
            {
                yellowLigth = false;
                spriteRenderer.sprite = sprite_redlight;
                stop = true;
                yield return new WaitForSeconds(13);
                
                spriteRenderer.sprite = sprite_greenlight;
                stop = false;
               
                yield return new WaitForSeconds(10);
               
                spriteRenderer.sprite = sprite_yellowlight;
                yellowLigth = true;
                stop = false;
                yield return new WaitForSeconds(3);
                

            }
            else
            {
                yellowLigth = false;
                spriteRenderer.sprite = sprite_greenlight;
                stop = false;
                //IntersectionControl();
                yield return new WaitForSeconds(10);
                spriteRenderer.sprite = sprite_yellowlight;
                yellowLigth = true;
                stop = false;                
                yield return new WaitForSeconds(3);
                spriteRenderer.sprite = sprite_redlight;
                stop = true;
                yield return new WaitForSeconds(13);
                

            }
            
            
            



        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (stop)
        {
            collision.gameObject.GetComponent<CarMovement>().velocity = 0;
        }
        //else
        //{
        //    collision.gameObject.GetComponent<CarMovement>().velocity = 5;
        //}
    }
    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    if (spriteRenderer.sprite == sprite_redlight)
    //    {
    //        collision.gameObject.GetComponent<CarMovement>().velocity = 0.5f;
    //    }
    //}


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!stop)
        {
            IntersectionControl(collision);
            //collision.gameObject.GetComponent<CarMovement>().velocity = 5;
        }
        ///se roba la luz en amarillo
        if (spriteRenderer.sprite == sprite_yellowlight)
        {
            collision.gameObject.GetComponent<CarMovement>().velocity = 7;
        }
    }

    async void IntersectionControl(Collider2D collider)
    {
        while (intersection.GetComponent<Intersection>().carsInIntersection > 0)
        {
            await Task.Yield();
        }
        collider.gameObject.GetComponent<CarMovement>().velocity = 5;

    }
}
