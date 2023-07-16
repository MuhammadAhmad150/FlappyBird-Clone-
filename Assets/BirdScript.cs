using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    //REFERENCE
    public Rigidbody2D myRigidBody;
    public float flapStrength=40;
    bool birdIsAlive=true;

    public LogicScript logic;

    void Start()
    {
        //gameObject.name="MAhmad";
        logic=GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        if(birdIsAlive){
        //myRigidBody.velocity = new Vector2(1, 1).normalized * 10;
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive)//SPACE
        {
          //myRigidBody.velocity=Vector2.up * flapStrength;
          myRigidBody.velocity = new Vector2(0, 2).normalized * 11;
        }

        if (Input.touchCount > 0)//TOUCH
        {
            myRigidBody.velocity = new Vector2(0, 1).normalized * 10;
        }
        }
        if(gameObject.transform.position.y>23 || gameObject.transform.position.y<-20)
         {  
             birdIsAlive=false;
             logic.gameOver();
         }
    }
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        //Debug.Log("Coll");
        logic.gameOver();
        birdIsAlive=false;
    }
    public void JUMP()//BUTTON
    {
        {
          myRigidBody.velocity=Vector2.up * flapStrength;
        }
    }
}
