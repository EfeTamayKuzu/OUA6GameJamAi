using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CokBasitSahneYukleme : MonoBehaviour
{
    public string sahneAdi;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(sahneAdi);
        }
    }
}
