using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight : MonoBehaviour
{
    public Sprite sprite_yellowlight;
    public Sprite sprite_redlight;
    public Sprite sprite_greenlight;
    public SpriteRenderer spriteRenderer;
    public float timer = 60;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 30)
        {
            spriteRenderer.sprite = sprite_redlight;

        }
        else if (timer >= 5)
        {
            spriteRenderer.sprite = sprite_greenlight;

        }
        else if (timer >= 0 )
        {
            spriteRenderer.sprite = sprite_yellowlight;

        }
        if (timer <= 0)
        {
            timer = 60;
        }
        timer -= Time.deltaTime;

    }
}
