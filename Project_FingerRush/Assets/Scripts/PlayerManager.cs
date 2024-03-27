using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : Singleton<PlayerManager>
{
    [Header("������Ʈ")]
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
