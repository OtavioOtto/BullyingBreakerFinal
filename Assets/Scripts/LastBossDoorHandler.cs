using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastBossDoorHandler : MonoBehaviour
{
    public RecruitedEnemiesHadler enemies;

    void Start()
    {
        if (enemies.boss3)
            this.gameObject.SetActive(false);
    }

    void Update()
    {
        
    }
}
