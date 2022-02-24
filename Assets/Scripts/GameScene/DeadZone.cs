using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadZone : MonoBehaviour
{
    

    private void OnCollisionEnter2D(Collision2D col) {

      
       Rigidbody2D rb = col.collider.GetComponent<Rigidbody2D>();

       if(rb != null){

           SceneManager.LoadScene(2);

          


           }
       }

       
       
   
   }
