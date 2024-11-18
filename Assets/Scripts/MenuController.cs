using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    [Header("Inventory System")]
    public InventoryHandler inventory;
    public RecruitedEnemiesHadler enemies;

    private void Start()
    {
        PlayerPrefs.DeleteAll();
        inventory.ResetValues();
        enemies.ResetValues();
    }
}
