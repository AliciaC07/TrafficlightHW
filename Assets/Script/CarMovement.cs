using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float velocity = 0;
    private bool visible = false;
    void Start()
    {
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
}
