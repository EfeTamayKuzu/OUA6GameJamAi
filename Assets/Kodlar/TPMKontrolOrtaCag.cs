using System.Collections;
using System.Collections.Generic;
using Unity.Android.Types;
using UnityEngine;

public class TPMKontrolOrtaCag : MonoBehaviour
{
    public GameObject tpm1, tpm2, tpm3;
    public AlveBirakBasit aVbb;

    public void Update()
    {
        if(aVbb.b == true)
        {
            tpm1.SetActive(false);
            tpm2.SetActive(true);
        }
        if(aVbb.b == true && aVbb.adam == true)
        {
            tpm2.SetActive(false);
            tpm3.SetActive(true);
        }
    }
}
