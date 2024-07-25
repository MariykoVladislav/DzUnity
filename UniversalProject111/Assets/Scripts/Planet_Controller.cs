using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet_Controller : MonoBehaviour
{
    public float speedRotation = 1f;//UnityMathF стала швидкість

    public float Speed_Acceleration = 7f;// швидкість з прискореням

    public float Delta_Force = 10f;

    public float test = 1f;

    public float test2 = 5f;



    
    void Start()
    {
        Debug.Log("Швидкість на початку :  " + " " + speedRotation);
    }
    

    public void Clicker()
    {
        speedRotation = 100;
        transform.Rotate(0, speedRotation * Time.deltaTime, 0);
    }
   
    void Update()
    {
       //створення камери  туди  й промінь
       Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
       //створення проміня + "пострілку"
       RaycastHit hit;
       transform.Rotate(0, speedRotation * Time.deltaTime, 0);

       //чи потрапляємо в обєкт чи ні
       if(Physics.Raycast(ray, out hit))
       {
         
         //перевіряємо чи промінь потрапив  саме сюди
         if(hit.transform  == transform)
         {
            //Отримуємо дані з мишки
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");
           // Debug.Log(mouseX);
           // Debug.Log(mouseY);
           // Debug.Log("потрапляємо" + hit + mouseX + mouseY);

           //Обертаємо обєкт навкого  його осей

            transform.Rotate(Vector3.up * -mouseX  * Speed_Acceleration * Time.deltaTime * Delta_Force);

            transform.Rotate(Vector3.right * mouseY  * Speed_Acceleration * Time.deltaTime * Delta_Force);

 
            speedRotation = 0;



          //  Debug.Log("Швидкість після наведеня :  " + " " + Speed_Acceleration);



         }
         


       }
           transform.Rotate(0, speedRotation * Time.deltaTime, 0);


        
    }
}
