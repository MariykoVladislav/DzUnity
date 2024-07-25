using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyKeyboard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          if(Input.GetKeyDown(KeyCode.E))
         {
            print("Натиснули кнопку - E");
            Destroy(gameObject);
         }

       
         
         

       
       
        
    }

   // void fly()
   //void reverse()
  
 
}
