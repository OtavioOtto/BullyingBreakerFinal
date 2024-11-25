using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class UIBanheiroHandler : MonoBehaviour
{
    [Header("Tela Recrutados")]
    [SerializeField] private GameObject recrutados;
    [SerializeField] private Button bully1Select;
    [SerializeField] private Button bully2Select;
    [SerializeField] private Button bully3Select;
    [SerializeField] private Button bully4Select;
    [SerializeField] private GameObject dadosBully1;
    [SerializeField] private GameObject dadosBully2;
    [SerializeField] private GameObject dadosBully3;
    [SerializeField] private GameObject dadosBully4;
    [SerializeField] private GameObject pencilBully1;
    [SerializeField] private GameObject pencilBully2;
    [SerializeField] private GameObject pencilBully3;
    [SerializeField] private GameObject pencilBully4;

    [Header("Dados Bullies")]
    [SerializeField] private GameObject bulliesRecruited;
    [SerializeField] private GameObject boss1Recruited;
    [SerializeField] private GameObject boss2Recruited;

    [Header("Tela Party")]
    [SerializeField] private GameObject party;
    [SerializeField] private Button jimmySelect;
    [SerializeField] private Button aliceSelect;
    [SerializeField] private Button itensSelect;

    [Header("Checks")]
    [SerializeField] private bool canChangeScreen = true;
    [SerializeField] private bool canUseGreen = true;

    [Header("Select")]
    [SerializeField] private GameObject pencilJimmy;
    [SerializeField] private GameObject pencilAlice;
    [SerializeField] private GameObject pencilItens;

    [Header("Tela Dados")]
    [SerializeField] private GameObject dadosJimmy;
    [SerializeField] private GameObject dadosAlice;
    [SerializeField] private GameObject dadosItens;

    [Header("Itens Game Object")]
    [SerializeField] private Button item1BTTN;
    [SerializeField] private Button item2BTTN;
    [SerializeField] private Button item3BTTN;
    [SerializeField] private Button item4BTTN;
    [SerializeField] private Button item5BTTN;
    [SerializeField] private Button item6BTTN;
    [SerializeField] private Button item7BTTN;
    [SerializeField] private Button item8BTTN;
    [SerializeField] private Button item9BTTN;

    [Header("Itens Texts")]
    [SerializeField] private TMP_Text item1Txt;
    [SerializeField] private TMP_Text item2Txt;
    [SerializeField] private TMP_Text item3Txt;
    [SerializeField] private TMP_Text item4Txt;
    [SerializeField] private TMP_Text item5Txt;
    [SerializeField] private TMP_Text item6Txt;
    [SerializeField] private TMP_Text item7Txt;
    [SerializeField] private TMP_Text item8Txt;
    [SerializeField] private TMP_Text item9Txt;

    [Header("Itens Select")]
    [SerializeField] private GameObject item1Select;
    [SerializeField] private GameObject item2Select;
    [SerializeField] private GameObject item3Select;
    [SerializeField] private GameObject item4Select;
    [SerializeField] private GameObject item5Select;
    [SerializeField] private GameObject item6Select;
    [SerializeField] private GameObject item7Select;
    [SerializeField] private GameObject item8Select;
    [SerializeField] private GameObject item9Select;

    [Header("Dados Alice")]
    [SerializeField] private GameObject buffAlicePencil;
    [SerializeField] private Button buffAliceSelect;
    [SerializeField] private TMP_Text aliceBuff;

    [Header("DadosJimmy")]
    [SerializeField] private GameObject buffJimmyPencil;
    [SerializeField] private Button buffJimmySelect;
    [SerializeField] private TMP_Text jimmyBuff;

    [Header("Health Bar")]
    [SerializeField] private Slider playerHealth;

    [Header("Symbols")]
    [SerializeField] private GameObject rightArrow;
    [SerializeField] private GameObject leftArrow;

    [Header("Inventory System")]
    public InventoryHandler inventory;

    [Header("Horizontal Direction")]
    [SerializeField] private float x0;

    string newBuff = "";
    private void Start()
    {
        jimmySelect.Select();
    }
    void Update()
    {
        x0 = Input.GetAxis("HORIZONTAL0");
        ChangeScreens();
        BullyAttributes();
        CharacterAttributes();
        CharacterAttributesScreen();
        BuffChange();
        HealItens();
        HealItensScreen();
        SetHealItemQuantities();
        ReturnButton();
        UpdatePlayerHealth();
    }
    private void ChangeScreens()
    {
        if (canChangeScreen)
        {
            rightArrow.SetActive(true);
            leftArrow.SetActive(true);
            if (Input.GetButtonDown("HORIZONTAL0"))
            {
                if (recrutados.activeSelf)
                {
                    recrutados.SetActive(false);
                    party.SetActive(true);
                    jimmySelect.Select();
                    pencilJimmy.SetActive(true);
                    pencilBully1.SetActive(false);
                }
                else if (party.activeSelf)
                {
                    party.SetActive(false);
                    recrutados.SetActive(true);
                    bully1Select.Select();
                    pencilBully1.SetActive(true);
                    pencilJimmy.SetActive(false);
                }
            }
        }
        else 
        {
            rightArrow.SetActive(false);
            leftArrow.SetActive(false);
        }
    }
    private void BullyAttributes()
    {

        if (recrutados.activeSelf && EventSystem.current.currentSelectedGameObject.GetComponent<Button>() == bully1Select)
        {
            pencilBully1.SetActive(true);
            dadosBully1.SetActive(true);
            pencilBully2.SetActive(false);
            dadosBully2.SetActive(false);
            pencilBully3.SetActive(false);
            dadosBully3.SetActive(false);
            pencilBully4.SetActive(false);
            dadosBully4.SetActive(false);
        }

        if (recrutados.activeSelf && EventSystem.current.currentSelectedGameObject.GetComponent<Button>() == bully2Select)
        {
            pencilBully2.SetActive(true);
            dadosBully2.SetActive(true);
            pencilBully1.SetActive(false);
            dadosBully1.SetActive(false);
            pencilBully3.SetActive(false);
            dadosBully3.SetActive(false);
            pencilBully4.SetActive(false);
            dadosBully4.SetActive(false);
        }

        if (recrutados.activeSelf && EventSystem.current.currentSelectedGameObject.GetComponent<Button>() == bully3Select)
        {
            pencilBully1.SetActive(false);
            dadosBully1.SetActive(false);
            pencilBully2.SetActive(false);
            dadosBully2.SetActive(false);
            pencilBully3.SetActive(true);
            dadosBully3.SetActive(true);
            pencilBully4.SetActive(false);
            dadosBully4.SetActive(false);
        }
        if (recrutados.activeSelf && EventSystem.current.currentSelectedGameObject.GetComponent<Button>() == bully4Select)
        {
            pencilBully1.SetActive(false);
            dadosBully1.SetActive(false);
            pencilBully2.SetActive(false);
            dadosBully2.SetActive(false);
            pencilBully3.SetActive(false);
            dadosBully3.SetActive(false);
            pencilBully4.SetActive(true);
            dadosBully4.SetActive(true);
        }

    }
    private void CharacterAttributes()
    {
        if (party.activeSelf && EventSystem.current.currentSelectedGameObject.GetComponent<Button>() == jimmySelect && !dadosJimmy.activeSelf)
        {

            pencilJimmy.SetActive(true);
            pencilAlice.SetActive(false);
            pencilItens.SetActive(false);
        }

        else if (party.activeSelf && EventSystem.current.currentSelectedGameObject.GetComponent<Button>() == aliceSelect && !dadosAlice.activeSelf)
        {
            pencilAlice.SetActive(true);
            pencilJimmy.SetActive(false);
            pencilItens.SetActive(false);

        }

    }
    private void HealItens()
    {

        if (party.activeSelf && EventSystem.current.currentSelectedGameObject.GetComponent<Button>() == itensSelect && !dadosAlice.activeSelf)
        {
            pencilItens.SetActive(true);
            pencilAlice.SetActive(false);
            pencilJimmy.SetActive(false);
            if (Input.GetButtonDown("VERDE0"))
            {
                pencilItens.SetActive(false);
                dadosItens.SetActive(true);
                item1Select.SetActive(true);
                item1BTTN.Select();
                canChangeScreen = false;

            }
        }
    }
    private void CharacterAttributesScreen()
    {

        if (dadosJimmy.activeSelf == true)
        {
            buffJimmyPencil.SetActive(true);
            buffJimmySelect.Select();
        }

        if (dadosAlice.activeSelf == true)
        {
            buffAlicePencil.SetActive(true);
            buffAliceSelect.Select();
        }
    }
    private void HealItensScreen()
    {

        if (dadosItens.activeSelf == true)
        {

            if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>() == item1BTTN)
            {
                item1Select.SetActive(true);
                item2Select.SetActive(false);
            }

            else if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>() == item2BTTN)
            {
                item1Select.SetActive(false);
                item2Select.SetActive(true);
                item3Select.SetActive(false);
            }

            else if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>() == item3BTTN)
            {
                item2Select.SetActive(false);
                item3Select.SetActive(true);
                item4Select.SetActive(false);
            }

            else if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>() == item4BTTN)
            {
                item3Select.SetActive(false);
                item4Select.SetActive(true);
                item5Select.SetActive(false);
            }

            else if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>() == item5BTTN)
            {
                item4Select.SetActive(false);
                item5Select.SetActive(true);
                item6Select.SetActive(false);
            }

            else if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>() == item6BTTN)
            {
                item5Select.SetActive(false);
                item6Select.SetActive(true);
                item7Select.SetActive(false);
            }

            else if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>() == item7BTTN)
            {
                item6Select.SetActive(false);
                item7Select.SetActive(true);
                item8Select.SetActive(false);
            }

            else if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>() == item8BTTN)
            {
                item7Select.SetActive(false);
                item8Select.SetActive(true);
                item9Select.SetActive(false);
            }

            else if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>() == item9BTTN)
            {
                item8Select.SetActive(false);
                item9Select.SetActive(true);
            }
        }
    }
    private void BuffChange()
    {
        string buffAtk = "+10% de Ataque";
        string buffHeal = "+20 de Cura";
        string buffEmpathy = "+15% de Empatia";
        if (dadosJimmy.activeSelf == true)
        {
            if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>() == buffJimmySelect)
            {
                if (!canChangeScreen && Input.GetButtonDown("HORIZONTAL0") && jimmyBuff.text == "")
                {
                    if (x0 > 0)
                    {
                        if (inventory.attackBuff)
                        {
                            jimmyBuff.text = buffAtk;
                            newBuff = "buffAtk";
                        }
                        else if (inventory.healingBuff)
                        {
                            jimmyBuff.text = buffHeal;
                            newBuff = "buffHeal";
                        }
                        else if (inventory.empathyBuff)
                        {
                            jimmyBuff.text = buffEmpathy;
                            newBuff = "buffEmpathy";
                        }
                        else
                            jimmyBuff.text = "Voce nao tem\nBuffs";
                    }
                    else if (x0 < 0)
                    {
                        if (inventory.empathyBuff)
                        {
                            jimmyBuff.text = buffEmpathy;
                            newBuff = "buffEmpathy";
                        }
                        else if (inventory.healingBuff)
                        {
                            jimmyBuff.text = buffHeal;
                            newBuff = "buffHeal";
                        }
                        else if (inventory.attackBuff)
                        {
                            jimmyBuff.text = buffAtk;
                            newBuff = "buffAtk";
                        }
                        else
                            jimmyBuff.text = "Voce nao tem\nBuffs";
                    }
                }

                else if (!canChangeScreen && ((Input.GetButtonDown("HORIZONTAL0") && x0 > 0 && jimmyBuff.text == buffAtk) || (Input.GetButtonDown("HORIZONTAL0") && x0 < 0 && jimmyBuff.text == buffEmpathy)))
                {
                    if (inventory.healingBuff)
                    {
                        jimmyBuff.text = buffHeal;
                        newBuff = "buffHeal";
                    }
                    else if (jimmyBuff.text == buffAtk)
                    {
                        if (inventory.empathyBuff)
                        {
                            jimmyBuff.text = buffEmpathy;
                            newBuff = "buffEmpathy";
                        }
                        else { }//n fzr nd pq ele n tem mais itens
                    }
                    else if (jimmyBuff.text == buffEmpathy)
                    {
                        if (inventory.attackBuff)
                        {
                            jimmyBuff.text = buffAtk;
                            newBuff = "buffAtk";
                        }
                        else { }//n fzr nd pq ele n tem mais itens
                    }
                }

                else if (Input.GetButtonDown("HORIZONTAL0") && x0 < 0 && !canChangeScreen && jimmyBuff.text == buffHeal)
                {

                    if (inventory.attackBuff)
                    {
                        jimmyBuff.text = buffAtk;
                        newBuff = "buffAtk";
                    }
                    else { }//n fzr nd pq ele n tem mais cadernos

                }

                else if (Input.GetButtonDown("HORIZONTAL0") && x0 > 0 && !canChangeScreen && jimmyBuff.text == buffHeal)
                {

                    if (inventory.empathyBuff)
                    {
                        jimmyBuff.text = buffEmpathy;
                        newBuff = "buffEmpathy";
                    }
                    else { }//n fzr nd pq ele n tem mais tesouras

                }
                if (Input.GetButtonDown("VERDE0") && canUseGreen)
                {

                    inventory.ChangeBuffs(newBuff, "player1");
                    dadosJimmy.SetActive(false);
                    pencilJimmy.SetActive(true);
                    jimmySelect.Select();
                    canChangeScreen = true;
                    canUseGreen = false;
                    StartCoroutine(GreenButtonCoolDown());
                }
            }
        }
        if (dadosAlice.activeSelf == true)
        {

            if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>() == buffAliceSelect)
            {
                if (!canChangeScreen && Input.GetButtonDown("HORIZONTAL0") && aliceBuff.text == "")
                {
                    if (x0 > 0)
                    {
                        if (inventory.attackBuff)
                        {
                            aliceBuff.text = buffAtk;
                            newBuff = "buffAtk";
                        }
                        else if (inventory.healingBuff)
                        {
                            aliceBuff.text = buffHeal;
                            newBuff = "buffHeal";
                        }
                        else if (inventory.empathyBuff)
                        {
                            aliceBuff.text = buffEmpathy;
                            newBuff = "buffEmpathy";
                        }
                        else
                            aliceBuff.text = "Voce nao tem\nBuffs";
                    }
                    else if (x0 < 0)
                    {
                        if (inventory.empathyBuff)
                        {
                            aliceBuff.text = buffEmpathy;
                            newBuff = "buffEmpathy";
                        }
                        else if (inventory.healingBuff)
                        {
                            aliceBuff.text = buffHeal;
                            newBuff = "buffHeal";
                        }
                        else if (inventory.attackBuff)
                        {
                            aliceBuff.text = buffAtk;
                            newBuff = "buffAtk";
                        }
                        else
                            aliceBuff.text = "Voce nao tem\nBuffs";
                    }
                }

                else if (!canChangeScreen && ((Input.GetButtonDown("HORIZONTAL0") && x0 > 0 && aliceBuff.text == buffAtk) || (Input.GetButtonDown("HORIZONTAL0") && x0 < 0 && aliceBuff.text == buffEmpathy)))
                {
                    if (inventory.healingBuff)
                    {
                        aliceBuff.text = buffHeal;
                        newBuff = buffHeal;
                    }
                    else if (aliceBuff.text == buffAtk)
                    {
                        if (inventory.empathyBuff)
                        {
                            aliceBuff.text = buffEmpathy;
                            newBuff = "buffEmpathy";
                        }
                        else { }//n fzr nd pq ele n tem mais itens
                    }
                    else if (aliceBuff.text == buffEmpathy)
                    {
                        if (inventory.attackBuff)
                        {
                            aliceBuff.text = buffAtk;
                            newBuff = "buffAtk";
                        }
                        else { }//n fzr nd pq ele n tem mais itens
                    }
                }

                else if (Input.GetButtonDown("HORIZONTAL0") && x0 < 0 && !canChangeScreen && aliceBuff.text == buffHeal)
                {

                    if (inventory.attackBuff)
                    {
                        aliceBuff.text = buffAtk;
                        newBuff = "buffAtk";
                    }
                    else { }//n fzr nd pq ele n tem mais cadernos

                }

                else if (Input.GetButtonDown("HORIZONTAL0") && x0 > 0 && !canChangeScreen && aliceBuff.text == buffHeal)
                {

                    if (inventory.empathyBuff)
                    {
                        aliceBuff.text = buffEmpathy;
                        newBuff = "buffEmpathy";
                    }
                    else { }//n fzr nd pq ele n tem mais tesouras

                }
                if (Input.GetButtonDown("VERDE0") && canUseGreen)
                {

                    inventory.ChangeBuffs(newBuff, "player2");
                    dadosAlice.SetActive(false);
                    pencilAlice.SetActive(true);
                    aliceSelect.Select();
                    canChangeScreen = true;
                    canUseGreen = false;
                    StartCoroutine(GreenButtonCoolDown());
                }
            }
        }
    }
    private void SetHealItemQuantities()
    {

        item1Txt.text = "Pao - 10 hp (" + inventory.paoQuant + ")";
        item2Txt.text = "Biscoito - 25 hp (" + inventory.biscoitoQuant + ")";
        item3Txt.text = "Energetico - 15 hp (" + inventory.energeticoQuant + ")";
        item4Txt.text = "Sanduiche - 40 hp 40% df (" + inventory.sanduicheQuant + ")";
        item5Txt.text = "Chocolate - 30 hp 30% atk (" + inventory.chocolateQuant + ")";
        item6Txt.text = "Melancia - 35 hp 50% df (" + inventory.melanciaQuant + ")";
        item7Txt.text = "Sobr. Mor - 50 hp 200% df (" + inventory.sobremesaQuant + ")";
        item8Txt.text = "Cafe - 45 hp 70% atk (" + inventory.cafeQuant + ")";
        item9Txt.text = "Kit Med. - 100 hp (" + inventory.kitQuant + ")";

    }
    public void JimmyAttributes() {

        if (inventory.currentEquippedBuff1 != "")
        {
            if (inventory.currentEquippedBuff1 == "buffAtk")
                jimmyBuff.text = "+10% de Ataque";
            else if (inventory.currentEquippedBuff1 == "buffHeal")
                jimmyBuff.text = "+20 de Cura";
            else if (inventory.currentEquippedBuff1 == "BuffEmpathy")
                jimmyBuff.text = "+15% de Empatia";
        }
        else
        {
            jimmyBuff.text = "";
        }
        dadosJimmy.SetActive(true);
        pencilJimmy.SetActive(false);
        canChangeScreen = false;
        canUseGreen = false;
        StartCoroutine(GreenButtonCoolDown());
    }
    public void AliceAttributes() { 
        if (inventory.currentEquippedBuff2 != "")
        {
            if (inventory.currentEquippedBuff2 == "buffAtk")
                aliceBuff.text = "+10% de Ataque";
            else if (inventory.currentEquippedBuff2 == "buffHeal")
                aliceBuff.text = "+20 de Cura";
            else if (inventory.currentEquippedBuff2 == "BuffEmpathy")
                aliceBuff.text = "+15% de Empatia";
        }
        else
        {
            aliceBuff.text = "";
        }
        pencilAlice.SetActive(false);
        dadosAlice.SetActive(true);
        canChangeScreen = false;
        canUseGreen = false;
        StartCoroutine(GreenButtonCoolDown());
    }
    public void ReturnButton() {
        if (Input.GetButtonDown("AMARELO0"))
        {
            if (!dadosItens.activeSelf && !dadosAlice.activeSelf && !dadosJimmy.activeSelf)
            {
                canChangeScreen = true;
                this.gameObject.SetActive(false);
            }
            else if (dadosAlice.activeSelf)
            {

                dadosAlice.SetActive(false);
                pencilAlice.SetActive(true);
                aliceSelect.Select();
                canChangeScreen = true;

            }

            else if (dadosJimmy.activeSelf)
            {

                dadosJimmy.SetActive(false);
                pencilJimmy.SetActive(true);
                jimmySelect.Select();
                canChangeScreen = true;

            }

            else if (dadosItens.activeSelf)
            {
                dadosItens.SetActive(false);
                pencilItens.SetActive(true);
                item2Select.SetActive(false);
                item3Select.SetActive(false);
                item4Select.SetActive(false);
                item5Select.SetActive(false);
                item6Select.SetActive(false);
                item7Select.SetActive(false);
                item8Select.SetActive(false);
                item9Select.SetActive(false);
                itensSelect.Select();
                canChangeScreen = true;

            }
        }

    }
    public void UseHealtem(string item)
    {
        if (item == "pao" && inventory.paoQuant > 0)
            inventory.HealPlayer(item);
        else if (item == "biscoito" && inventory.biscoitoQuant > 0)
            inventory.HealPlayer(item);
        else if (item == "energetico" && inventory.energeticoQuant > 0)
            inventory.HealPlayer(item);
        else if (item == "sanduiche" && inventory.sanduicheQuant > 0)
            inventory.HealPlayer(item);
        else if (item == "chocolate" && inventory.chocolateQuant > 0)
            inventory.HealPlayer(item);
        else if (item == "melancia" && inventory.melanciaQuant > 0)
            inventory.HealPlayer(item);
        else if (item == "sobremesa" && inventory.sobremesaQuant > 0)
            inventory.HealPlayer(item);
        else if (item == "cafe" && inventory.cafeQuant > 0)
            inventory.HealPlayer(item);
        else if (item == "kit" && inventory.kitQuant > 0)
            inventory.HealPlayer(item);

        inventory.ResetTemporaryBuffs();
    }
    public void UpdatePlayerHealth() {
        playerHealth.value = inventory.hp;
    }
    private IEnumerator GreenButtonCoolDown()
    {
        yield return new WaitForSeconds(0.25f);
        canUseGreen = true;
    }
    
}