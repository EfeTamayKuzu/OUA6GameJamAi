using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopTemasi : MonoBehaviour
{
    bool kontrol = false;
    public GameObject portal, tetik;
    public GameObject baskettopu;
    public GameObject tpm2, tpm3;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Nesne"))
        {
            portal.SetActive(true);
            tetik.SetActive(true);
            kontrol = true;
            if(kontrol == true)
            {
                baskettopu.SetActive(false);
                tpm2.SetActive(false);
                tpm3.SetActive(true);
            }
        }

    }
}
