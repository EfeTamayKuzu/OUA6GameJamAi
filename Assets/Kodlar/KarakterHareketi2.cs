using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class KarakterHareketi2 : MonoBehaviour
{
    public Camera oyuncuKamerasi;
    public float yurumeHizi = 6f;
    public float kosmaHizi = 12f;
    public float ziplamaGucu = 7f;
    public float yerCekimi = 10f;

    public float lookSpeed = 2f;
    public float lookXLimit = 45f;

    Vector3 hareketYonu = Vector3.zero;
    float rotationX = 0;

    public bool hareketEdebilir = true;

    CharacterController cK;

    private void Start()
    {
        cK = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    private void Update()
    {
        #region Handles Movement
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        bool kosuyorMu = Input.GetKey(KeyCode.LeftShift);
        float hizX = hareketEdebilir ? (kosuyorMu ? kosmaHizi : yurumeHizi) * Input.GetAxis("Vertical") : 0;
        float hizY = hareketEdebilir ? (kosuyorMu ? kosmaHizi : yurumeHizi) * Input.GetAxis("Horizontal") : 0;
        float movementDirectionY = hareketYonu.y;
        hareketYonu = (forward * hizX) + (right * hizY);

        #endregion

        #region Handles Jumping
        if(Input.GetButton("Jump") && hareketEdebilir && cK.isGrounded)
        {
            hareketYonu.y = ziplamaGucu;
        }
        else
        {
            hareketYonu.y = movementDirectionY;
        }
        if (!cK.isGrounded)
        {
            hareketYonu.y -= yerCekimi * Time.deltaTime;
        }

        #endregion

        #region Handles Rotation

        cK.Move(hareketYonu * Time.deltaTime);

        if (hareketEdebilir)
        {
            rotationX += -Input.GetAxis("Mouse Y") * lookSpeed;
            rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);
            oyuncuKamerasi.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
            transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed, 0);
        }

        #endregion
        


    }
}
