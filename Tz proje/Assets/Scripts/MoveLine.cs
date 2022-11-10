using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLine : MonoBehaviour
{
    private Transform LineTransform;
   public float Sped;
    void Start()
    {
        LineTransform = GetComponent<Transform>();
    }

   
    // Update is called once per frame
    public  void Update()
    {
   
    }
   
    public  void MoveLin(float Speed)
    {
         float Sped = Speed;
        Vector3 LineSpeed = transform.position;
        LineSpeed.y += Sped * Time.deltaTime; 
        LineTransform.position = (LineSpeed);

    }

 
}
