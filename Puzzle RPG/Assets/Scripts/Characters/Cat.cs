using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Character
{
    // Start is called before the first frame update
    private void Awake()
    {
        base.Awake();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        base.FixedUpdate();
    }

     void OnTriggerStay2D(UnityEngine.Collider2D collision)
    {
        
        base.OnTriggerStay2D (collision);

    }
}
