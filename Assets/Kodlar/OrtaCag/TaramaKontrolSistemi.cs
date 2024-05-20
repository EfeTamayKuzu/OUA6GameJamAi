using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaramaKontrolSistemi : MonoBehaviour
{
    public GameObject emptyObject; // Empty objemizi buradan sürükleyip býrakacaðýz
    public GameObject cubeObject; // Küp objemizi buradan sürükleyip býrakacaðýz
    public bool kontroltpm2 = false;

    void Update()
    {
        // Empty objemizdeki tüm nesnelerin SetActive durumunu kontrol ediyoruz
        bool allInactive = true;
        foreach (Transform child in emptyObject.transform)
        {
            if (child.gameObject.activeSelf) // Eðer bir nesne aktifse
            {
                allInactive = false; // Tüm nesneler aktif deðil, false yap
                break; // Döngüden çýk
            }
        }

        // Tüm nesnelerin SetActive durumu false ise
        if (allInactive)
        {
            cubeObject.SetActive(true); // Küpün SetActive'ini true yap
            kontroltpm2 = true;
        }
        else
        {
            cubeObject.SetActive(false); // Aksi takdirde küpü false yap
        }
    }
}
