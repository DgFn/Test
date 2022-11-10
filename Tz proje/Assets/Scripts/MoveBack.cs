using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBack : MonoBehaviour
{
    public float Speed;
    private Transform back_Transform;
    private float back_Size;
    private float back_pos;
    public GameObject Game;
    void Start()
    {
        back_Transform = GetComponent<Transform>();
        back_Size = GetComponent<SpriteRenderer>().bounds.size.y;
        StartCoroutine(BoostSpeed());
    }
        
    public void ChooseSpeed(float Speeds)
    {
        Speed += Speeds;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Speed *= -1;
            MoveUp();
        }
 
        if (Input.GetKeyUp(KeyCode.W))
        {
            Speed *= -1;
            MoveUp();
        }
        MoveUp();
    }


    IEnumerator BoostSpeed()
    {
        if(Speed / 10 == 1 & Speed / -10 == 1)
        {
            StopAllCoroutines();
        }

        yield return new WaitForSeconds(15);

       if(Speed >= 0)
        {
            Speed += 1;
        }
       else
        {
            Speed -= 1;
        }
       
        StartCoroutine(BoostSpeed());
    }

    public void MoveUp()
    {
        back_pos += Speed * Time.deltaTime;
        back_pos = Mathf.Repeat(back_pos, back_Size);
        back_Transform.position = new Vector3(0, back_pos, 0);
        FindObjectOfType<MoveLine>().MoveLin(Speed);
    }

    public void StopGame()
    {
        Speed = 0;
        StopAllCoroutines();
        Game.SetActive(false);
    }
  
}
