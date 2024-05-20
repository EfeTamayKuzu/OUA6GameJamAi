using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YayMekanigi : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = -10;
    public Transform biz;
    public GameObject ben;
    public GameObject isik;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isik.SetActive(false);
            this.transform.SetParent(ben.transform);
            this.transform.position = ben.transform.position;
            this.transform.rotation = ben.transform.rotation;
            Debug.Log("Razor adam.");
        }
    }
}
