using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Subject
{
    private Score _score;
    // Start is called before the first frame update
    void Start()
    {
        _score = gameObject.AddComponent<Score>();
    }

    // Update is called once per frame

    private void OnEnable()
    {
        Attach(_score);
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.W))
        {
            transform.Translate(Vector3.up );
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            transform.Translate(Vector3.down );
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            transform.Translate(Vector3.left );
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            transform.Translate(Vector3.right );
        }
       
        if (Input.GetKeyUp(KeyCode.Space))
        {
            NotifyObservers();
        }
        
    }
}
