using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource_Collect : MonoBehaviour
{

    public float speedRotation = 40f;//UnityMathF

  
    void Update()
    {
      transform.Rotate(0, speedRotation * Time.deltaTime, 0);
    }
    
    private void OnTriggerEnter(Collider other)
    {
      if(other.tag == "Player")
      {
        
        Resources_collection.Amount_Resource_Gold++;
     
        Destroy(gameObject);

      }
    }

}
