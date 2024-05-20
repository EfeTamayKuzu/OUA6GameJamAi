using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ok : MonoBehaviour
{
    public float life = 3;
    public GameObject k1;

    private void Awake()
    {
        Destroy(gameObject, life);
    }

    private void Start()
    {
        k1.SetActive(true);
    }

    /*private void OnCollisionEnter(Collision collision)
    {
        
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
    */
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Vurulabilir"))
        {
            other.gameObject.SetActive(false);
            Destroy(gameObject); 
        }
    }
}
