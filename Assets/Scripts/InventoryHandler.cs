using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player Inventory")]
public class InventoryHandler : ScriptableObject
{
    [Header("Quantidade Itens")]
    public int sanduicheQuant;
    public int biscoitoQuant;
    public int energeticoQuant;
    public int chocolateQuant;
    public int paoQuant;
    public int melanciaQuant;
    public int sobremesaQuant;
    public int cafeQuant;
    public int kitQuant;

    [Header("Buffs")]
    public bool attackBuff = false;
    public bool healingBuff = false;
    public bool empathyBuff = false;

    [Header("Buffs Temporarios")]
    public float temporaryAttackBuff;
    public float temporaryDefenseBuff;

    [Header("Itens Equipados Player 1")]
    public string currentAttackItem1;
    public string currentDefenseItem1;
    public string currentEquippedBuff1;

    [Header("Stats Players")]
    public float hp = 1;

    [Header("Itens Equipados Player 2")]
    public string currentAttackItem2;
    public string currentDefenseItem2;
    public string currentEquippedBuff2;

    [Header("Papeis Encontrados")]
    public bool papel1;
    public bool papel2;
    public bool papel3;

    [Header("Inimigos Recrutados")]
    public RecruitedEnemiesHadler enemies;
    
    public float ReturnDamageValue(string qualPlayer) {
        if (qualPlayer == "player1")
        {
            if (currentAttackItem1 != null)
            {
                if (currentAttackItem1 == "caderno")
                    return 2f;
                else if (currentAttackItem1 == "lapis")
                    return 3f;
                else if (currentAttackItem1 == "tesoura")
                    return 6f;
            }
        }
        else if (qualPlayer == "player2")
        {
            if (currentAttackItem2 != null)
            {
                if (currentAttackItem2 == "caderno")
                    return 2f;
                else if (currentAttackItem2 == "lapis")
                    return 3f;
                else if (currentAttackItem2 == "tesoura")
                    return 6f;
            }
        }
        return 0f;
    }
    public float ReturnDefenseValue(string qualPlayer)
    {
        if (qualPlayer == "player1")
        {
            if (currentDefenseItem1 != null)
            {
                if (currentDefenseItem1 == "broche")
                    return 0.03f;
                else if (currentDefenseItem1 == "oculos")
                    return 0.05f;
                else if (currentDefenseItem1 == "jaqueta")
                    return 0.09f;
            }
        }
        else if (qualPlayer == "player2")
        {
            if (currentDefenseItem2 != null)
            {
                if (currentDefenseItem2 == "broche")
                    return 0.03f;
                else if (currentDefenseItem2 == "oculos")
                    return 0.05f;
                else if (currentDefenseItem2 == "jaqueta")
                    return 0.09f;
            }
        }
        return 0f;
    }
    public void GotItem(string name) {
        if (name == "sanduiche")
            sanduicheQuant++;

        else if (name == "biscoito")
            biscoitoQuant++;

        else if (name == "energetico")
            energeticoQuant++;

        else if (name == "chocolate")
            chocolateQuant++;

        else if (name == "pao")
            paoQuant++;

        else if (name == "melancia")
            melanciaQuant++;

        else if (name == "sobremesa")
            sobremesaQuant++;

        else if (name == "cafe")
            cafeQuant++;

        else if (name == "kit")
            kitQuant++;
    }
    public void HealPlayer(string item) {
        if (item == "pao")
        {
            hp += .10f;
            paoQuant--;
        }

        else if (item == "biscoito") 
        {
            hp += .25f;
            biscoitoQuant--;
        }

        else if (item == "energetico")
        {
            hp += .15f;
            energeticoQuant--;
        }

        else if (item == "chocolate")
        {
            hp += .30f;
            chocolateQuant--;
            temporaryAttackBuff = 1.3f;
        }

        else if (item == "sanduiche")
        {
            hp += .40f;
            temporaryDefenseBuff = 1.5f;
            sanduicheQuant--;
        }

        else if (item == "melancia")
        {
            hp += .35f;
            melanciaQuant--;
            temporaryDefenseBuff = 1.8f;
        }

        else if (item == "sobremesa")
        {
            hp += .5f;
            sobremesaQuant--;
            temporaryDefenseBuff = 2f;
        }

        else if (item == "cafe")
        {
            hp += .45f;
            sobremesaQuant--;
            temporaryAttackBuff = 1.7f;
        }

        else if (item == "kit")
        {
            hp += 1;
            kitQuant--;
        }

        if (hp > 1)
            hp = 1;
    }
    public void ChangeBuffs(string newBuff, string qualPlayer)
    {
        if (qualPlayer == "player1")
        {
            Debug.Log(newBuff);
            if (currentEquippedBuff1 != "")
            {
                if (currentEquippedBuff1 == "buffAtk" && currentEquippedBuff1 != newBuff)
                    attackBuff = true;
                else if (currentEquippedBuff1 == "buffHeal" && currentEquippedBuff1 != newBuff)
                    healingBuff = true;
                else if (currentEquippedBuff1 == "buffEmpathy" && currentEquippedBuff1 != newBuff)
                    empathyBuff = true;
            }
            if (newBuff == "buffAtk" && currentEquippedBuff1 != newBuff)
                attackBuff = false;
            else if (newBuff == "buffHeal" && currentEquippedBuff1 != newBuff)
                healingBuff = false;
            else if (newBuff == "buffEmpathy" && currentEquippedBuff1 != newBuff)
                empathyBuff = false;
            currentEquippedBuff1 = newBuff;
        }

        if (qualPlayer == "player2")
        {
            if (currentAttackItem1 != "")
            {
                if (currentEquippedBuff2 == "buffAtk" && currentEquippedBuff2 != newBuff)
                    attackBuff = true;
                else if (currentEquippedBuff2 == "buffHeal" && currentEquippedBuff2 != newBuff)
                    healingBuff = true;
                else if (currentEquippedBuff2 == "buffEmpathy" && currentEquippedBuff2 != newBuff)
                    empathyBuff = true;
            }
            if (newBuff == "buffAtk" && currentEquippedBuff2 != newBuff)
                attackBuff = false;
            else if (newBuff == "buffHeal" && currentEquippedBuff2 != newBuff)
                healingBuff = false;
            else if (newBuff == "buffEmpathy" && currentEquippedBuff2 != newBuff)
                empathyBuff = false;
            currentEquippedBuff2 = newBuff;
        }
    }
    public void ResetValues() 
    {
        sanduicheQuant = 0;
        biscoitoQuant = 0;
        energeticoQuant = 0;
        chocolateQuant = 0;
        paoQuant = 0;
        melanciaQuant = 0;
        sobremesaQuant = 0;
        cafeQuant = 0;
        kitQuant = 0;
        attackBuff = false;
        healingBuff = false;
        empathyBuff = false;
        hp = 1;
    }
    public void ResetTemporaryBuffs() {

        temporaryAttackBuff = 0;
        temporaryDefenseBuff = 0;

    }
}
