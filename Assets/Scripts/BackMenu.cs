using UnityEngine;
using UnityEngine.SceneManagement;

public class TopDownContoller : MonoBehaviour
{

    private float menu;

    void Start()
    {
        menu = Input.GetAxis("MENU");
        Menu();
    }

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