using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorGenerator : MonoBehaviour
{
    public GameObject floorPreb;
    private Transform floorTr;

    public static FloorGenerator instance;

    private void Awake() {
        instance = this;
    }


    public int floorcount;

    public float offset;
    public float minY;
    public float maxY;

    private Vector3 spawnPoint;

    private Vector2 newScale;

    void Start() {
        floorTr = floorPreb.GetComponent<Transform>();

        spawnPoint = new Vector3();
        newScale = new Vector2();

        

        for(int i = 0 ; i < floorcount ; i++){
            Spawn();
            
        }


        
    }

    public void Spawn(){
            newScale.x = Random.Range(3.9f,4.1f);
            newScale.y = Random.Range(0.4f,0.45f);

            floorTr.localScale = newScale;

            spawnPoint.y += Random.Range(minY,maxY);

            spawnPoint.x = Random.Range(-offset,offset);

            Instantiate(floorPreb,spawnPoint,Quaternion.identity);

    }

}
