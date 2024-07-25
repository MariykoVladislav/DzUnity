using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
     public void NextLevel()
    {
        SceneManager.LoadScene(1);//виклик сцени по індексу
        //SceneManager.LoadScene("Scenes/Level_1.unity");//виклик сцени по назві
    }
     public void REPLAY_Level()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  
       Debug.Log("Респаун по кнопці працює!");
       
    }

    public void ABOUTLevel()
    {
        SceneManager.LoadScene("Scenes/About");
    }
    public void Menu_Level()
    {
      
        SceneManager.LoadScene("Scenes/Menu_Main_Page");//виклик сцени по назві
    }

    
    public void ExitGame()
    {
       // UnityEditor.EditorApplication.isPlaying = false;//Спрацює тільки локально в Юніті
        Application.Quit();//Тільки у білді спрацює
    }
}
