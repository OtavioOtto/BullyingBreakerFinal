using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCollider : MonoBehaviour
{
    [Header("Collider Verifier")]
    [SerializeField] private bool playerIsInside = false;
    public RecruitedEnemiesHadler enemies;
    public string battleNumber;
    public GameObject text;
    public GameObject tileMap1;
    public GameObject tileMap2;
    public GameObject tileMap3;
    public GameObject tileMap4;
    private void Start()
    {
        if (enemies.battle1 && enemies.battle2 && enemies.battle3 && enemies.battle4)
            SceneManager.LoadScene("Final");
        battleNumber = transform.GetChild(0).name;
        if (enemies.lastBattle != "")
        {
            if (enemies.won && enemies.lastBattle == battleNumber)
            {
                enemies.SetBattleDeactivated(battleNumber);
            }
        }
        if (battleNumber == "um" && enemies.battle1)
        {
            this.gameObject.SetActive(false);
            tileMap1.SetActive(false);
        }
        else if (battleNumber == "dois" && enemies.battle2)
        {
            this.gameObject.SetActive(false);
            tileMap2.SetActive(false);
        }
        else if (battleNumber == "tres" && enemies.battle3)
        {
            this.gameObject.SetActive(false);
            tileMap3.SetActive(false);
        }
        else if (battleNumber == "quatro" && enemies.battle4)
        {
            this.gameObject.SetActive(false);
            tileMap4.SetActive(false);
        }
    }
    private void Update()
    {
        
        if (playerIsInside && Input.GetButtonDown("VERDE0"))
        {
            enemies.SetLastBattle(battleNumber);
            SceneManager.LoadScene("NormalBattle");
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            text.SetActive(true);
            playerIsInside = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            text.SetActive(false);
            playerIsInside = false;
        }
    }
}
