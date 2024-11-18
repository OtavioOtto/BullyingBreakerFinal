using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Recrutied Enemies")]
public class RecruitedEnemiesHadler : ScriptableObject
{
    [Header("Quantidades de recrutados")]
    public bool battle1 = false;
    public bool battle2 = false;
    public bool battle3 = false;
    public bool battle4 = false;

    [Header("Quantidades de bosses recrutados")]
    public bool boss1 = false;
    public bool boss2 = false;
    public bool boss3 = false;

    [Header("Informações batalhas")]
    public bool won = false;
    public string lastBattle;

    public void CanDestroyEnemy(string ganhou) {

        if (ganhou == "sim")
            won = true;
        else
            won = false;

    }

    public void SetLastBattle(string battle) {

        lastBattle = battle;

    }
    public void SetBattleDeactivated(string battle) {
        if (battle == "um")
            battle1 = true;
        else if (battle == "dois")
            battle2 = true;
        else if (battle == "tres")
            battle3 = true;
        else if (battle == "quatro")
            battle4 = true;
        else if (battle == "Boss_1")
            boss1 = true;
        else if (battle == "Boss_2")
            boss2 = true;
        else if (battle == "Boss_3")
            boss3 = true;
    }

    public void ResetValues()
    {
        battle1 = false;
        battle2 = false;
        battle3 = false;
        battle4 = false;
        boss1 = false;
        boss2 = false;
        boss3 = false;
        won = false;
        lastBattle = "";
    }
}
