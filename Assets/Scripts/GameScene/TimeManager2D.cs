using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager2D : MonoBehaviour
{

    public SpriteRenderer player;
    public Color basse;
    public Color onCooldown;

    public float slowFac = 0.1f;

    public float slowLenght = 5f;

    public float cooldown = 6f;

    private float started = 0f;

    private bool iscoolDown = false;

    private bool isSlow = false;

    

    void BulletTime(){
        Time.timeScale = slowFac;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
    }
 
    

    private void Update() {


        if(iscoolDown){
            player.color = onCooldown;
        }
        if(!iscoolDown){
            player.color = basse;
        }

        if(isSlow){
            Time.timeScale += (1f / slowLenght) * Time.unscaledDeltaTime;
            Time.timeScale = Mathf.Clamp(Time.timeScale,0f,1f);

            if(Time.timeScale >= 1f) {
                isSlow = false;
            }
        }
       
       
        if(Time.time > started + cooldown){
            iscoolDown = false;
            
        }

        if(Input.GetMouseButton(1)){



            if(isSlow){

            }
            else{

                if(iscoolDown){


                }
                else{
                   
                    isSlow = true;
                    // call func
                    BulletTime();
                    started = Time.time;
                
                }


            }
        }
    }

}
