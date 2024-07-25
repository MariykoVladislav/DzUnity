using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Resources_collection : MonoBehaviour
{
    public static float Amount_Resource_Gold = 0f;

    public static float Amount_Resource_Diamond = 0f;

    public TextMeshProUGUI  Gold_Amount_Text;

    public TextMeshProUGUI  Diamond_Amount_Text;



    void Update()
    {
       Diamond_Amount_Text.text = " " + Amount_Resource_Diamond;
       Gold_Amount_Text.text = " " + Amount_Resource_Gold;
        
    }
}
