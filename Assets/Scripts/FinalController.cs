using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class FinalController : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Button restartButton;
    [SerializeField] private GameObject finalText;
    [SerializeField] private GameObject lore;
    [SerializeField] private GameObject loreBG;
    [SerializeField] private int texto = 1;
    private void Update()
    {
        if (Input.GetButtonDown("VERDE0")) 
        {
            if (texto == 3)
            {
                restartButton.gameObject.SetActive(true);
                finalText.SetActive(true);
                lore.SetActive(false);
                loreBG.SetActive(false);
            }

            else
                texto++;
        }

        if (texto == 1)
            lore.GetComponent<TMP_Text>().text = "A 'Escola Sol Nascente' se transforma completamente. O bullying, que antes era uma praga que permeava todos os cantos da escola, agora eh coisa do passado. ";

        else if (texto == 2)
            lore.GetComponent<TMP_Text>().text = "Com a ajuda de Jimmy e Vanessa a escola passa a ser um modelo de inclusao e empatia. Os alunos comecam a compreender que nao ha vergonha em ser vulneravel e que todos têm seu valor, independentemente de suas notas ou habilidades.";

        else if (texto == 3)
            lore.GetComponent<TMP_Text>().text = "A escola, finalmente, deixa de ser um lugar de competicao implacavel e se torna um espaço de aprendizado, acolhimento e apoio para todos.";
    }
}
