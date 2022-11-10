using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject obj, Line;
    private float LineY;
    private float LineX;
   

    void Start()
    {
      GameObject clone = Instantiate(obj, obj.transform.position, obj.transform.rotation) as GameObject;
        clone.transform.parent = transform;
        LineX = Random.Range(-1.65f, 1.65f);
        LineY = Random.Range(-0.5f, 5f);
        GameObject Lineclone = Instantiate(Line, Line.transform.position, obj.transform.rotation) as GameObject;
        Lineclone.transform.position = new Vector3(LineX, LineY, 0);
        Lineclone.transform.parent = transform;

    }

    public void SpawnLine()
    {
        LineX = Random.Range(-1.65f, 1.65f);
        LineY = Random.Range(-1f, 5f);
        GameObject Lineclone = Instantiate(Line, Line.transform.position, obj.transform.rotation) as GameObject;
        Lineclone.transform.position = new Vector3(LineX, LineY, 0);
        Lineclone.transform.parent = transform;
    }

   
    void OnTriggerEnter(Collider collision)
    {
        Destroy(collision.gameObject);
    }
  
}
