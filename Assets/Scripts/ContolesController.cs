using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ContolesController : MonoBehaviour
{

    public void ReturnButton()
    {
        SceneManager.LoadScene(0);
    }


}
