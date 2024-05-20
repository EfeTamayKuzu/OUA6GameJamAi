using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopHizasi : MonoBehaviour
{
    public GameObject player, objectToAttach , kapsul;
    public GameObject tpm1, tpm2;
    public YayMekanigi yM;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            objectToAttach.transform.SetParent(player.transform);
            objectToAttach.transform.localPosition = Vector3.zero;
            objectToAttach.transform.localRotation = Quaternion.identity;
            objectToAttach.transform.localScale = Vector3.one;
            yM.enabled = true;
            kapsul.SetActive(false);
            tpm1.SetActive(false);
            tpm2.SetActive(true);
        }
    }
}
