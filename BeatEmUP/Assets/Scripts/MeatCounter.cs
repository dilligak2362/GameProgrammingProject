using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MeatCounter : MonoBehaviour
{
    public static MeatCounter instance;

    public TMP_Text meatText;
    public int currentMeats = 0;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        meatText.text = "MEATS: " + currentMeats.ToString();
    }

    
   public void IncreaseMeats(int v)
    {
        currentMeats += v;
        meatText.text = "MEATS: " + currentMeats.ToString();
    }
}
