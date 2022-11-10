using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadLine : MonoBehaviour
{
    public Transform Linet;
    

    private void Update()
    {
        
    }
    void OnTriggerEnter(Collider collision)
    {
        FindObjectOfType<Spawn>().SpawnLine();
        Destroy(collision.gameObject);
        
    }
}
