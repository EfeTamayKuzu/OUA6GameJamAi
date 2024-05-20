using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TMPKontrol : MonoBehaviour
{
    public GameObject tpm1, tpm2, tpm3;
    
    public YayMekanigi ym;
    public TaramaKontrolSistemi tks;
    

    public void Update()
    {
        if(ym.kontrolTMP == true)
        {
            tpm1.SetActive(false);
            tpm2.SetActive(true);
        }
        if(tks.kontroltpm2 == true)
        {
            tpm2.SetActive(false);
            tpm3.SetActive(true);
        }
        
    }
}
