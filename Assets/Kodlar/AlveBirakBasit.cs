using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AlveBirakBasit : MonoBehaviour
{
    public GameObject odun;
    public Transform hedef2;
    public GameObject KampAtesi;
    public GameObject isaret;
    public GameObject Portal;
    public bool b = false;
    public bool adam = false;
    public string sahneismi;

    private void Start()
    {
        odun.SetActive(true);
        isaret.SetActive(true);
        KampAtesi.SetActive(false);
        Portal.SetActive(false);
        
    }

    private void Update()
    {
        if (adam == true)
        {
            odun.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Nesne"))
        {
            odun.SetActive(false);
            isaret.SetActive(false);
            b = true;
        }

        if (other.CompareTag("Kamp"))
        {
            if (b == true)
            {
                adam = true;
                if (adam == true)
                {
                    odun.SetActive(true);  // odun'u tekrar etkinleþtiriyoruz
                    odun.transform.position = hedef2.transform.position;
                    KampAtesi.SetActive(true);
                    Portal.SetActive(true);
                }
            }
        }
        if (other.CompareTag("Portal"))
        {
            SceneManager.LoadScene(sahneismi);
        }
    }
}
