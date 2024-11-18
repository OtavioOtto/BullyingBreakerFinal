using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class GameController : MonoBehaviour
{
    [Header("People")]
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;
    [SerializeField] private GameObject enemy;

    [Header("Health Bar")]
    [SerializeField] private Slider playerHealth;
    [SerializeField] private Slider enemyHealth;
    [SerializeField] private Slider enemyAura;

    [Header("Character Selection")]
    [SerializeField] private GameObject player1Selection;
    [SerializeField] private GameObject player2Selection;
    [SerializeField] private GameObject enemySelection;

    [Header("End Screens")]
    [SerializeField] private GameObject enemyDefeated;
    [SerializeField] private GameObject enemyConverted;
    [SerializeField] private GameObject enemyWon;

    [Header("Player Actions")]
    [SerializeField] private float playerAttackValue = .05f;
    [SerializeField] private float playerEmpathyValue = .06f;

    [Header("Action Buttons")]
    [SerializeField] private Button attackButton;
    [SerializeField] private Button empathyButton;
    [SerializeField] private Button itemButton;
    [SerializeField] private Button fleeButton;

    [Header("Action Buttons Text")]
    [SerializeField] private GameObject attackButtonTxt;
    [SerializeField] private GameObject empathyButtonTxt;
    [SerializeField] private GameObject itemButtonTxt;
    [SerializeField] private GameObject fleeButtonTxt;

    [Header("GameObject Buttons")]
    [SerializeField] private GameObject attackButtonGM;
    [SerializeField] private GameObject empathyButtonGM;
    [SerializeField] private GameObject itemButtonGM;
    [SerializeField] private GameObject fleeButtonGM;
    [SerializeField] private GameObject nextSceneEnemyDefeatedGM;
    [SerializeField] private GameObject nextSceneEnemyConvertedGM;
    [SerializeField] private GameObject resetSceneGM;

    [Header("Buttons Attack")]
    [SerializeField] private Button firstAttackButton;
    [SerializeField] private GameObject firstAttackButtonTxt;
    [SerializeField] private Button secondAttackButton;
    [SerializeField] private GameObject secondAttackButtonTxt;

    [Header("Buttons Empathy")]
    [SerializeField] private Button firstEmpathyButton;
    [SerializeField] private GameObject firstEmpathyButtonTxt;
    [SerializeField] private Button secondEmpathyButton;
    [SerializeField] private GameObject secondEmpathyButtonTxt;

    [Header("Buttons Items")]
    [SerializeField] private Button firstItemButton;
    [SerializeField] private GameObject firstItemButtonTxt;
    [SerializeField] private Button secondItemButton;
    [SerializeField] private GameObject secondItemButtonTxt;
    [SerializeField] private Button thirdItemButton;
    [SerializeField] private GameObject thirdItemButtonTxt;

    [Header("Buttons Groups")]
    [SerializeField] private GameObject itemOptions;
    [SerializeField] private GameObject empathyOptions;
    [SerializeField] private GameObject attackOptions;
    [SerializeField] private GameObject defaultOptions;

    [Header("Ending Screens Buffs")]
    [SerializeField] private GameObject atkBuffGO;
    [SerializeField] private GameObject empathyBuffGO;
    [SerializeField] private GameObject atkHealBuffGO;
    [SerializeField] private GameObject empathyHealBuffGO;

    [Header("Enemy Stats")]
    [SerializeField] private float enemyAttackValue = 0.10f;
    [SerializeField] private float enemyHealthValue = 1.0f;
    [SerializeField] private float enemyAuraValue = 1.0f;

    [Header("Enemy Images")]
    [SerializeField] private GameObject firstEnemy;
    [SerializeField] private GameObject secondEnemy;
    [SerializeField] private GameObject thirdEnemy;

    [Header("Player Stats")]
    [SerializeField] private float battlePoints;
    [SerializeField] private TMP_Text battlePointsTxt;

    [Header("Itens")]
    [SerializeField] private int curativos;
    [SerializeField] private int sucos;
    [SerializeField] private int frutas;

    private List<GameObject> turnOrder;
    private int currentTurnIndex;
    private float menu;
    private float itemDefenseValue1;
    private float itemDefenseValue2;
    private float attackBuff;
    private float empathyBuff;
    private float healBuff;
    private bool healBuffUnlocked = false;
    private bool normalBuffUnlocked = false;
    public bool ganhou = false;
    [Header("Player inventory")]
    public InventoryHandler inventory;
    public RecruitedEnemiesHadler enemies;
    void Start()
    {
        if (inventory.currentDefenseItem1 != "")
            itemDefenseValue1 = inventory.ReturnDefenseValue("player1");
        if (inventory.currentDefenseItem2 != "")
            itemDefenseValue2 = inventory.ReturnDefenseValue("player2");
        if (inventory.currentEquippedBuff1 == "buffAtk" || inventory.currentEquippedBuff2 == "buffAtk")
            attackBuff = 0.15f;
        if (inventory.currentEquippedBuff1 == "buffEmpathy" || inventory.currentEquippedBuff2 == "buffEmpathy")
            empathyBuff = 0.2f;
        if (inventory.currentEquippedBuff1 == "buffHeal" || inventory.currentEquippedBuff2 == "buffHeal")
            healBuff = 0.3f;

        InitializeGame();
        SetEnemy();
    }
    private void Update()
    {
        playerHealth.value = inventory.hp;
        curativos = inventory.curativoQuant;
        sucos = inventory.sucoQuant;
        frutas = inventory.frutaQuant;
        menu = Input.GetAxis("MENU");
        Menu();
        SetButtonTexts();
        ReturnToDefaultButtons();
        UpdateBattlePoints();
    }
    private void InitializeGame()
    {
        turnOrder = new List<GameObject> { player1, player2, enemy };
        currentTurnIndex = 0;
        enemyHealth.maxValue = enemyHealthValue;
        enemyHealth.value = enemyHealthValue;
        enemyAura.maxValue = enemyAuraValue;
        enemyAura.value = enemyAuraValue;
        UpdateTurn();
    }
    private void UpdateTurn()
    {
        DeactivateSelections();
        DisableActionButtons();

        if (turnOrder[currentTurnIndex] == player1)
        {
            ActivatePlayer1Turn();
            defaultOptions.SetActive(true);
            itemOptions.SetActive(false);
            empathyOptions.SetActive(false);
            attackOptions.SetActive(false);
            EventSystem.current.SetSelectedGameObject(attackButtonGM);
        }
        else if (turnOrder[currentTurnIndex] == player2)
        {
            ActivatePlayer2Turn();
            defaultOptions.SetActive(true);
            itemOptions.SetActive(false);
            empathyOptions.SetActive(false);
            attackOptions.SetActive(false);
            EventSystem.current.SetSelectedGameObject(attackButtonGM);
        }
        else if (turnOrder[currentTurnIndex] == enemy)
        {
            attackButtonTxt.SetActive(false);
            empathyButtonTxt.SetActive(false);
            itemButtonTxt.SetActive(false);
            fleeButtonTxt.SetActive(false);
            defaultOptions.SetActive(true);
            itemOptions.SetActive(false);
            empathyOptions.SetActive(false);
            attackOptions.SetActive(false);
            ActivateEnemyTurn();
        }
    }
    private void DeactivateSelections()
    {
        player1Selection.SetActive(false);
        player2Selection.SetActive(false);
        enemySelection.SetActive(false);
    }
    private void DisableActionButtons()
    {
        attackButton.interactable = false;
        empathyButton.interactable = false;
        itemButton.interactable = false;
        fleeButton.interactable = false;

    }
    private void ActivatePlayer1Turn()
    {
        player1Selection.SetActive(true);
        EnableActionButtons();
    }
    private void ActivatePlayer2Turn()
    {
        player2Selection.SetActive(true);
        EnableActionButtons();
    }
    private void ActivateEnemyTurn()
    {
        enemySelection.SetActive(true);
        StartCoroutine(EnemyAttackRoutine());
    }
    private void EnableActionButtons()
    {
        attackButton.interactable = true;
        empathyButton.interactable = true;
        itemButton.interactable = true;
        fleeButton.interactable = true;
    }
    private IEnumerator EnemyAttackRoutine()
    {
        yield return new WaitForSeconds(1.0f);
        if (inventory.currentDefenseItem1 != "" || inventory.currentDefenseItem2 != "")
            playerHealth.value -= playerHealth.maxValue * (enemyAttackValue - (itemDefenseValue1 + itemDefenseValue2));
        else
            playerHealth.value -= playerHealth.maxValue * enemyAttackValue;
        if (playerHealth.value <= 0)
        {
            enemies.CanDestroyEnemy("nao");
            enemyWon.SetActive(true);
            EventSystem.current.SetSelectedGameObject(resetSceneGM);
        }
        else
        {
            inventory.hp = playerHealth.value;
            yield return new WaitForSeconds(1.0f);
            NextTurn();
        }
    }
    public void EmpathyOptions()
    {

        if (battlePoints >= 15)
        {
            empathyOptions.SetActive(true);
            secondEmpathyButton.interactable = true;
            defaultOptions.SetActive(false);
            firstEmpathyButton.Select();
        }


        else
        {
            empathyOptions.SetActive(true);
            defaultOptions.SetActive(false);
            firstEmpathyButton.Select();
            secondEmpathyButton.interactable = false;
        }

    }
    public void EmpathyButton(GameObject chonsenButton) {

        AdjustEnemyAura(chonsenButton);

        if (enemyAura.value == 0)
        {
            enemyConverted.SetActive(true);
            if (inventory.empathyBuff && !inventory.healingBuff)
            {
                inventory.healingBuff = true;
                healBuffUnlocked = true;
            }
            if (!inventory.empathyBuff)
            {
                normalBuffUnlocked = true;
                inventory.empathyBuff = true;
            }
            if (normalBuffUnlocked)
                empathyBuffGO.SetActive(true);
            else if (healBuffUnlocked)
                empathyHealBuffGO.SetActive(true);
            enemies.CanDestroyEnemy("sim");
            EventSystem.current.SetSelectedGameObject(nextSceneEnemyConvertedGM);
        }
        else
        {
            NextTurn();
        }

    }
    private void AdjustEnemyAura(GameObject buttonOBJ)
    {
        if (inventory.empathyBuff)
        {
            if (buttonOBJ == firstEmpathyButton.gameObject)
            {
                enemyAura.value -= enemyAura.maxValue * (playerEmpathyValue + empathyBuff);
            }

            else if (buttonOBJ == secondEmpathyButton.gameObject)
            {
                battlePoints -= 15;
                enemyAura.value -= enemyAura.maxValue * (playerEmpathyValue * 2.5f + empathyBuff);
            }
        }
        else
        {
            if (buttonOBJ == firstEmpathyButton.gameObject)
            {
                enemyAura.value -= enemyAura.maxValue * playerEmpathyValue;
            }

            else if (buttonOBJ == secondEmpathyButton.gameObject)
            {
                enemyAura.value -= enemyAura.maxValue * playerEmpathyValue * 2;
            }
        }


    }
    public void AttackOptions()
    {
        if (turnOrder[currentTurnIndex] == player1)
        {
            if (battlePoints >= 10 && inventory.currentAttackItem1 != "")
            {
                attackOptions.SetActive(true);
                secondAttackButton.interactable = true;
                defaultOptions.SetActive(false);
                firstAttackButton.Select();
            }


            else
            {
                attackOptions.SetActive(true);
                defaultOptions.SetActive(false);
                firstAttackButton.Select();
                secondAttackButton.interactable = false;
            }
        }

        if (turnOrder[currentTurnIndex] == player2)
        {
            if (battlePoints > 10 && inventory.currentAttackItem2 != "")
            {
                attackOptions.SetActive(true);
                secondAttackButton.interactable = true;
                defaultOptions.SetActive(false);
                firstAttackButton.Select();
            }


            else
            {
                attackOptions.SetActive(true);
                defaultOptions.SetActive(false);
                firstAttackButton.Select();
                secondAttackButton.interactable = false;
            }
        }

    }
    public void AttackButton(GameObject chosenButton)
    {
        AdjustEnemyHealth(chosenButton);

        if (enemyHealth.value == 0)
        {
            enemyDefeated.SetActive(true);

            if (inventory.attackBuff && !inventory.healingBuff)
            {
                healBuffUnlocked = true;
                inventory.healingBuff = true;
            }
            if (!inventory.attackBuff)
            {
                normalBuffUnlocked = true;
                inventory.attackBuff = true;
            }
            if (normalBuffUnlocked)
                atkBuffGO.SetActive(true);
            else if (healBuffUnlocked)
                atkHealBuffGO.SetActive(true);
            enemies.CanDestroyEnemy("sim");
            EventSystem.current.SetSelectedGameObject(nextSceneEnemyDefeatedGM);

        }
        else
        {
            NextTurn();
        }
    }
    public void FleeButton() {

        enemies.CanDestroyEnemy("nao");
        SceneManager.LoadScene("TopDown(Game)");

    }
    private void ReturnToDefaultButtons() {

        if (attackOptions.activeSelf && Input.GetButtonDown("BRANCO0")) {

            attackOptions.SetActive(false);
            defaultOptions.SetActive(true);
            attackButton.Select();

        }

        else if (empathyOptions.activeSelf && Input.GetButtonDown("BRANCO0"))
        {

            empathyOptions.SetActive(false);
            defaultOptions.SetActive(true);
            empathyButton.Select();

        }

        else if (itemOptions.activeSelf && Input.GetButtonDown("BRANCO0"))
        {

            itemOptions.SetActive(false);
            defaultOptions.SetActive(true);
            itemButton.Select();

        }

    }
    private void AdjustEnemyHealth(GameObject buttonOBJ)
    {
        if (inventory.attackBuff)
        {
            if (buttonOBJ == firstAttackButton.gameObject)
            {
                enemyHealth.value -= enemyHealth.maxValue * (playerAttackValue + attackBuff);
            }

            else if (buttonOBJ == secondAttackButton.gameObject)
            {
                battlePoints -= 10;
                enemyHealth.value -= enemyHealth.maxValue * (playerAttackValue * 2 + attackBuff);
            }
        }
        else
        {
            if (buttonOBJ == firstAttackButton.gameObject)
            {
                enemyHealth.value -= enemyHealth.maxValue * playerAttackValue;
            }

            else if (buttonOBJ == secondAttackButton.gameObject)
            {
                battlePoints -= 10;
                enemyHealth.value -= enemyHealth.maxValue * playerAttackValue * 2;
            }
        }
    }
    public void ItemOptions()
    {
        itemOptions.SetActive(true);
        defaultOptions.SetActive(false);
        if (curativos > 0 && sucos == 0 && frutas == 0)
        {
            firstItemButton.Select();
            firstItemButton.interactable = true;
            secondItemButton.interactable = false;
            thirdItemButton.interactable = false;
        }

        else if (curativos > 0 && sucos > 0 && frutas == 0)
        {
            firstItemButton.Select();
            firstItemButton.interactable = true;
            secondItemButton.interactable = true;
            thirdItemButton.interactable = false;
        }

        else if (curativos > 0 && sucos > 0 && frutas > 0)
        {
            firstItemButton.Select();
            firstItemButton.interactable = true;
            secondItemButton.interactable = true;
            thirdItemButton.interactable = true;
        }

        else if (curativos == 0 && sucos > 0 && frutas == 0)
        {
            secondItemButton.Select();
            firstItemButton.interactable = false;
            secondItemButton.interactable = true;
            thirdItemButton.interactable = false;
        }

        else if (curativos == 0 && sucos > 0 && frutas > 0)
        {

            secondItemButton.Select();
            firstItemButton.interactable = false;
            secondItemButton.interactable = true;
            thirdItemButton.interactable = true;
        }

        else if (curativos > 0 && sucos == 0 && frutas > 0)
        {
            firstItemButton.Select();
            firstItemButton.interactable = true;
            secondItemButton.interactable = false;
            thirdItemButton.interactable = true;
            Debug.Log("chego");
        }

        else if (curativos == 0 && sucos == 0 && frutas > 0)
        {
            thirdItemButton.Select();
            firstItemButton.interactable = false;
            secondItemButton.interactable = false;
            thirdItemButton.interactable = true;
        }
        else {
            firstItemButtonTxt.SetActive(false);
            secondItemButtonTxt.SetActive(false);
            thirdItemButtonTxt.SetActive(false);
            firstItemButton.interactable = false;
            secondItemButton.interactable = false;
            thirdItemButton.interactable = false;
        }
    }
    public void ItemButton(string itemName)
    {
        AdjustPlayerHealth(itemName);
        NextTurn();
    }
    private void AdjustPlayerHealth(string item) {

        if (item == "curativo")
        {
            playerHealth.value += playerHealth.maxValue * 0.1f + healBuff;
            inventory.HealPlayer("curativo");
        }

        if (item == "suco")
        {
            playerHealth.value += playerHealth.maxValue * 0.15f + healBuff;
            inventory.HealPlayer("suco");
        }

        if (item == "fruta")
        {
            playerHealth.value += playerHealth.maxValue * 0.25f + healBuff;
            inventory.HealPlayer("fruta");
        }

    }
    private void NextTurn()
    {
        if (turnOrder[currentTurnIndex] == enemy)
            battlePoints += 4;
        currentTurnIndex = (currentTurnIndex + 1) % turnOrder.Count;
        UpdateTurn();


    }
    public void ResetSceneButton()
    {
        SceneManager.LoadScene("TopDown(Game)");
    }
    public void NextSceneButton()
    {
            SceneManager.LoadScene("TopDown(Game)");
    }
    private void Menu()
    {

        if (menu > 0.0f)
            SceneManager.LoadScene(0);

    }
    private void SetButtonTexts()
    {
        if (defaultOptions.activeSelf)
        {
            if (EventSystem.current.currentSelectedGameObject == attackButtonGM)
            {
                attackButtonTxt.SetActive(true);
                empathyButtonTxt.SetActive(false);
                itemButtonTxt.SetActive(false);
                fleeButtonTxt.SetActive(false);
            }

            if (EventSystem.current.currentSelectedGameObject == empathyButtonGM)
            {
                attackButtonTxt.SetActive(false);
                empathyButtonTxt.SetActive(true);
                itemButtonTxt.SetActive(false);
                fleeButtonTxt.SetActive(false);
            }

            if (EventSystem.current.currentSelectedGameObject == itemButtonGM)
            {
                attackButtonTxt.SetActive(false);
                empathyButtonTxt.SetActive(false);
                itemButtonTxt.SetActive(true);
                fleeButtonTxt.SetActive(false);
            }

            if (EventSystem.current.currentSelectedGameObject == fleeButtonGM)
            {
                attackButtonTxt.SetActive(false);
                empathyButtonTxt.SetActive(false);
                itemButtonTxt.SetActive(false);
                fleeButtonTxt.SetActive(true);
            }
        }

        if (attackOptions.activeSelf)
        {
            if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>() == firstAttackButton)
            {
                firstAttackButtonTxt.SetActive(true);
                secondAttackButtonTxt.SetActive(false);

            }

            if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>() == secondAttackButton)
            {
                firstAttackButtonTxt.SetActive(false);
                secondAttackButtonTxt.SetActive(true);

            }
        }

        if (empathyOptions.activeSelf)
        {
            if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>() == firstEmpathyButton)
            {
                firstEmpathyButtonTxt.SetActive(true);
                secondEmpathyButtonTxt.SetActive(false);

            }

            if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>() == secondEmpathyButton)
            {
                firstEmpathyButtonTxt.SetActive(false);
                secondEmpathyButtonTxt.SetActive(true);

            }
        }

        if (itemOptions.activeSelf)
        {
            if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>() == firstItemButton)
            {
                firstItemButtonTxt.SetActive(true);
                secondItemButtonTxt.SetActive(false);
                thirdItemButtonTxt.SetActive(false);

            }

            if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>() == secondItemButton)
            {
                firstItemButtonTxt.SetActive(false);
                secondItemButtonTxt.SetActive(true);
                thirdItemButtonTxt.SetActive(false);

            }

            if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>() == thirdItemButton)
            {
                firstItemButtonTxt.SetActive(false);
                secondItemButtonTxt.SetActive(false);
                thirdItemButtonTxt.SetActive(true);

            }
        }

    }
    private void UpdateBattlePoints()
    {

        battlePointsTxt.text = "" + battlePoints;

    }
    private void SetEnemy()
    {
        int chance = Random.Range(1, 4);
        if (chance == 1)
            firstEnemy.SetActive(true);
        if (chance == 2)
            secondEnemy.SetActive(true);
        if (chance == 3)
            thirdEnemy.SetActive(true);
    }
}
