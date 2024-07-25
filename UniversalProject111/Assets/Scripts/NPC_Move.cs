using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Move : MonoBehaviour
{
    public   GameObject Dialog_Panel;//????? false

    public float speed_npc = 3.0f;//швидкість друга
    private int step_npc = 0;//
    private int Target = 0;//куди рухатися
    private Vector3[] positions = new Vector3[3];

    void Start()
    {
        positions[0] = transform.position;//початкова позиція NPC
        positions[1] = positions[0] + new Vector3(5, 0, 0);//10 кроків вперед
        positions[2] = positions[0];//поверення до початкової точки

        //Debug.Log(transform.position);//current position == 
       // Debug.Log(positions[1]);
       // Debug.Log(positions[2]);
        
    }
     private void OnTriggerEnter(Collider other)
    {
      if(other.tag == "Player")
      {
        Dialog_Panel.SetActive(true);//false = true
      
     

      }
    }
    void Update()
    {
       Move();
        
    }
    void  Move()
    {
        if(Target < positions.Length)
        {
            //рух до позиції
          transform.position = Vector3.MoveTowards(transform.position, positions[Target],speed_npc * Time.deltaTime);

          if (transform.position == positions[Target])
          {
            Target++;
          }



        }
    }
    

}
