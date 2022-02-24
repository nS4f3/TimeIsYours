using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
   public float force;
   private bool istouched;
   private int isDoubleProbability;
   private Animator anim;

   


   private void Start() {
       anim = GetComponent<Animator>();
       isDoubleProbability = Random.Range(1,21);

       if(isDoubleProbability == 1){
           anim.SetBool("isDouble",true);
           force = 20f;
       }
   }

   
   

   private void OnCollisionEnter2D(Collision2D col) {

       if(col.relativeVelocity.y < 0){
       Rigidbody2D rb = col.collider.GetComponent<Rigidbody2D>();

       if(rb != null){


           Vector2 jump = rb.velocity;

           jump.y = force;

           rb.velocity = jump;

           if(!istouched){
               GameMaster2D.scorenum += Random.Range(1,6);
               istouched = true;
               anim.SetBool("isTouched",true);
               FloorGenerator.instance.Spawn();
               Destroy(gameObject,1f);
                


           }
       }

       
       
   }
   }
}
