﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight : MonoBehaviour
{
    public Sprite sprite_yellowlight;
    public Sprite sprite_redlight;
    public Sprite sprite_greenlight;
    public SpriteRenderer spriteRenderer;
    public float timer = 60;
    public bool stop = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 30)
        {
            spriteRenderer.sprite = sprite_redlight;
            stop = true;

        }
        else if (timer >= 5)
        {
            spriteRenderer.sprite = sprite_greenlight;
            stop = false;

        }
        else if (timer >= 0 )
        {
            spriteRenderer.sprite = sprite_yellowlight;
            stop = true;

        }
        if (timer <= 0)
        {
            timer = 60;
        }
        timer -= Time.deltaTime;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (stop)
        {
            collision.gameObject.GetComponent<CarMovement>().velocity = 0;
        }
        else
        {
            collision.gameObject.GetComponent<CarMovement>().velocity = 5;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!stop)
        {
            collision.gameObject.GetComponent<CarMovement>().velocity = 5;
        }
    }
}
