using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//БІБЛІОТЕКА сцен

public class Respawn_zone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void PlayScene()
    {
       
       SceneManager.LoadScene("Scenes/Level_1");
        
    }

      private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
 
            SceneManager.LoadScene("Scenes/Level_1");
            Debug.Log("Respawn Level");
 
        }
 
    }
}
