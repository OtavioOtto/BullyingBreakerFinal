using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TopDownController : MonoBehaviour
{

    private float menu;

    // Start is called before the first frame update
    void Start()
    {
        menu = Input.GetAxis("MENU");
        Menu();
    }

    // Update is called once per frame
    void Update()
    {
        menu = Input.GetAxis("MENU");
        Menu();
    }

    private void Menu()
    {

        if (menu > 0.0f)
            SceneManager.LoadScene("MainMenu");

    }
}
