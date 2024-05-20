using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaramaKontrolSistemi : MonoBehaviour
{
    public GameObject emptyObject; // Empty objemizi buradan s�r�kleyip b�rakaca��z
    public GameObject cubeObject; // K�p objemizi buradan s�r�kleyip b�rakaca��z

    void Update()
    {
        // Empty objemizdeki t�m nesnelerin SetActive durumunu kontrol ediyoruz
        bool allInactive = true;
        foreach (Transform child in emptyObject.transform)
        {
            if (child.gameObject.activeSelf) // E�er bir nesne aktifse
            {
                allInactive = false; // T�m nesneler aktif de�il, false yap
                break; // D�ng�den ��k
            }
        }

        // T�m nesnelerin SetActive durumu false ise
        if (allInactive)
        {
            cubeObject.SetActive(true); // K�p�n SetActive'ini true yap
        }
        else
        {
            cubeObject.SetActive(false); // Aksi takdirde k�p� false yap
        }
    }
}
