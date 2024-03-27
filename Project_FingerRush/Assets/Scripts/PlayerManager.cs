using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : Singleton<PlayerManager>
{
    [Header("ÄÄÆ÷³ÍÆ®")]
    PlayerStatus playerStatus;



    void Start()
    {
        playerStatus = GetComponent<PlayerStatus>();
    }

    public void UpdateExp(int _exp)
    {
        playerStatus.UpdateExp(_exp);
    }
}
