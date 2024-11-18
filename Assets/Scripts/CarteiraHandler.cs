using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarteiraHandler : MonoBehaviour
{
    private readonly string[] itens = {"curativo","suco","fruta","energetico","barra"};
    public string item;
    void Start()
    {
        int chance = Random.Range(0,101);
        if (chance <= 60)
        {
            int position = Random.Range(0, 2);
            item = itens[position];
            transform.GetChild(0).name = item;
        }

        else if (chance > 60 && chance < 90)
        {
            int position = Random.Range(2, 4);
            item = itens[position];
            transform.GetChild(0).name = item;
        }

        else {
            item = itens[4];
            transform.GetChild(0).name = item;
        }
    }


}