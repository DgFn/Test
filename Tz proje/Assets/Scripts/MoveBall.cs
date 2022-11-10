using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public float forcel;
    public float forcep;
    public float forcer;
    private float Ball;
    private Transform ball_Transform;
    private bool MoveB;
    public GameObject LST;
    void Start()
    {
        ball_Transform = GetComponent<Transform>();
    }
  

    // Update is called once per frame
    void Update()
    {

            if (Input.GetKeyDown(KeyCode.A))
            {
            forcep = forcel;
            }
        MoveLeft();
        if (Input.GetKeyUp(KeyCode.A))
        {
            forcep = 0;

            MoveLeft();
        }

        if (Input.GetKeyDown(KeyCode.D))
            {
            forcep = forcer;
            }
        if (Input.GetKeyUp(KeyCode.D))
        {
            forcep = 0;
            MoveRight();
        }
        MoveRight();
   
    }

    public void StopBall()
    {
        if (Ball < -2.45 | Ball > 2.45)
        {
            forcep = 0;
        }
        else
        {
            forcel = -2.45f;
            forcer = 2.45f;
        }
    }

    private void MoveLeft()
    {
        Ball += forcep * Time.deltaTime;
        StopBall();
        Ball += forcep * Time.deltaTime;
        ball_Transform.position = new Vector3(Ball, -3, 0);
        Vector3 rotate = transform.eulerAngles;
        rotate.y = Ball * 45;
        ball_Transform.rotation = Quaternion.Euler(rotate);
        
       
    }

 




    private void MoveRight()
    {
        Ball += forcep * Time.deltaTime;
        StopBall();
        ball_Transform.position = new Vector3(Ball, -3, 0);
        Vector3 rotate = transform.eulerAngles;
        rotate.y = Ball * -45;
        ball_Transform.rotation = Quaternion.Euler(rotate);
    }
   
}
