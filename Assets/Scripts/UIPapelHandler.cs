using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIPapelHandler : MonoBehaviour
{
    [SerializeField] private TMP_Text texto;

    

    public void SetText(string qualPapel) {

        if (qualPapel == "um") { 
        
            texto.text = "Essa escola era referencia de sucesso academico, com alunos brilhantes e altas taxas de aprovacao. Mas, a pressao por desempenho gerou um ambiente onde o foco estava apenas nas notas e isso acabou comigo...";
        
        }

        else if (qualPapel == "dois")
        {

            texto.text = "O bullying se espalhou muito na escola, alimentado pela pressao por resultados. Alunos com dificuldades eram ridicularizados, mas a administracao abafava os casos para proteger a reputacao da escola.";

        }

        else if (qualPapel == "tres")
        {

            texto.text = "Com a chegada dos 2 alunos novos, a empatia comecou a transformar a escola. Eles parecem enfrentar o bullying e promover a inclusao. Talvez vejamos mudanca depois de tanto tempo";

        }

    }
}
