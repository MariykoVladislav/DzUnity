using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContoller : MonoBehaviour
{
    public  float speedCamera = 0.001f;

    public float shift_move = 0.04f;



    void Start()
    {
        
    }

    void Update()
    {
          if(Input.GetKeyDown(KeyCode.D))
         {
            print("Натиснули кнопку - D");

            speedCamera = 0.1f;

            shift_move = 0.1f;
      
            transform.Translate(new Vector3(speedCamera,0f, 0f));

         }
           if(Input.GetKeyDown(KeyCode.A))
         {
            print("Натиснули кнопку - A");

            shift_move = -0.4f;

            speedCamera = 0;
          
            transform.Translate(new Vector3(shift_move,0f, 0f));
         }
  
      
      transform.Translate(new Vector3(speedCamera,0.001f, 0f));


    }
}
