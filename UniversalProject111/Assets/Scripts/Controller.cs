using System.Collections;
using System.Collections.Generic;
using UnityEngine;//Library C# Unity

public class Controller : MonoBehaviour
{
   public  static int healtbar = 100;//здоровя

   public  static float speedPlayer = 5;//швидкість гравця

  // public   GameObject GameOver_Panel = false;
   
   
   void Update()//call every frame
   { 
     Move();
    // Jump();
    //Attack();
     // Defend();

     if(healtbar == 0)
     {
      // SetActive.GameOver_Panel(true);
       
     }

   }


    void Start()
   {
    
   }

   void Move()
   {

    //For keyboard
     float x = Input.GetAxis("Horizontal");//X - вліво та вправо

     float z = Input.GetAxis("Vertical");//Z - вперед та назад

     Vector3 movement = new Vector3(x, 0.0f, z);

     transform.Translate(movement * speedPlayer * Time.deltaTime);
    //Debug.Log(x);
    // Debug.Log(z);
    //Debug.Log(movement);
   }


}
