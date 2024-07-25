using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_Btn : MonoBehaviour
{
    public   GameObject Pause_Panel;//????? false

  

    public void Pause()
    {
       Pause_Panel.SetActive(true);//false = true

     //  Controller.speedPlayer = 0;
      
       Time.timeScale = 0;//зупинка часу

       Debug.Log("Зупинили гру!");
    }

    public void Resume()
    {
        Pause_Panel.SetActive(false);//false = true

        //Controller.speedPlayer = 5;

        Time.timeScale = 1;//зупинка часу 

        Debug.Log("Продовжили гру!");

    }
  
}
