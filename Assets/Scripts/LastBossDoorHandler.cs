using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastBossDoorHandler : MonoBehaviour
{
    public RecruitedEnemiesHadler enemies;

    void Start()
    {
        if (enemies.battle1 && enemies.battle2 && enemies.battle3 && enemies.battle4 && enemies.boss1 && enemies.boss2)
            this.gameObject.SetActive(false);
    }
}
