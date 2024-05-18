using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonController : MonoBehaviour
{
    public float hiz = 5;
    public float hassasiyet = 3;

    private float yatayDondurme = 0;
    private float dikeyDondurme = 0;

    private void Update()
    {
        //Fare eksenleri hareketlerini al.
        yatayDondurme += hassasiyet * Input.GetAxisRaw("Mouse X");
        dikeyDondurme -= hassasiyet * Input.GetAxisRaw("Mouse Y");

        //Dikey d�n��� s�n�rla.
        dikeyDondurme = Mathf.Clamp(dikeyDondurme, -90, 90);

        //Yatay ve dikey d�n��� uygula.
        transform.eulerAngles = new Vector3(dikeyDondurme, yatayDondurme, 0);

        //�leri, geri, sa�a ve sola hareket.
        float ileriGeriHareket = Input.GetAxis("Vertical") * hiz;
        float sagaSolaHareket = Input.GetAxis("Horizontal") * hiz;

        //Hareketi d�nya koordinatlar�na g�re uygula.
        transform.Translate(sagaSolaHareket * Time.deltaTime, 0, ileriGeriHareket * Time.deltaTime);
    }
}
