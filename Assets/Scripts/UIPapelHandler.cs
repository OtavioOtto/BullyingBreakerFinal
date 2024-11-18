using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIPapelHandler : MonoBehaviour
{
    [SerializeField] private TMP_Text texto;

    

    public void SetText(string qualPapel) {

        if (qualPapel == "um") { 
        
            texto.text = "~texto1~";
        
        }

        else if (qualPapel == "dois")
        {

            texto.text = "~texto2~";

        }

        else if (qualPapel == "tres")
        {

            texto.text = "~texto3~";

        }

    }
}
