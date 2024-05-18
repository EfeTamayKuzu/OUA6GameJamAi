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

        //Dikey dönüþü sýnýrla.
        dikeyDondurme = Mathf.Clamp(dikeyDondurme, -90, 90);

        //Yatay ve dikey dönüþü uygula.
        transform.eulerAngles = new Vector3(dikeyDondurme, yatayDondurme, 0);

        //Ýleri, geri, saða ve sola hareket.
        float ileriGeriHareket = Input.GetAxis("Vertical") * hiz;
        float sagaSolaHareket = Input.GetAxis("Horizontal") * hiz;

        //Hareketi dünya koordinatlarýna göre uygula.
        transform.Translate(sagaSolaHareket * Time.deltaTime, 0, ileriGeriHareket * Time.deltaTime);
    }
}
