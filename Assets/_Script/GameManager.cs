using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Unity.UI;
using UnityEngine.UI;
using Button = UnityEngine.UI.Button;

public class GameManager : MonoBehaviour
{

    public static GameManager Class = null;
    
       public bool Key = false;
       public Button Basla;
       public Text solSkor,sagSkor;
       public int skorDegerR = 0,skorDegerL =0;
       

    private void Awake()
    {
        if (Class == null)
            Class = this;
        solSkor.text = skorDegerL.ToString();
        solSkor.text = skorDegerR.ToString();
    }



    public void baslatFonk()
    {

        Key = true;
        
        Basla.gameObject.SetActive(false);
    }
    


    public void UpdateScore(int skor)
    {
        switch (skor)
        {
            case 1:
                skorDegerL++;
                solSkor.text = skorDegerL.ToString();
                break;
            case 2:
                skorDegerR++;
                sagSkor.text = skorDegerR.ToString();
                break;
        }

    }

}