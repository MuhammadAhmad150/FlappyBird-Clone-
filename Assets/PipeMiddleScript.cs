using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{

    //Refeerence
    public LogicScript logic;
    //throw script snce not created in scene view

    // Start is called before the first frame update
    void Start()
    {
        logic=GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //on Trigger Exit
    //on Trigger Stay
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
            logic.addScore(1);
    }
}
