using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float xLimit = 0f;
    //public int yLimit = 70f;
    public Transform PlayerBody;//гравець, за яким слідкує камера

    public float sensitivity = 100f;//швидкість камера


 
    void Start()
    {
        // Cursor.lockState = CursorLockMode.Locked;//приховати курсор + по центру
        
    }

    // Update is called once per frame
    void Update()
    {
        float MouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;

        float MouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        xLimit -= MouseY;//оберт по осі X
        xLimit = Mathf.Clamp(xLimit, -70f, 70f);


        transform.localRotation =  Quaternion.Euler(xLimit, 0f, 0f);//оберти по осі X

        PlayerBody.Rotate(Vector3.up * MouseX);



        
    }
}
