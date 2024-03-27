using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Profiling;
using static UnityEditor.PlayerSettings;

public class PlayerStatus : MonoBehaviour
{
    public const int MAX_LEVEL = 777;

    [Header("컴포넌트")]
    [SerializeField] ProfileUI profileUI;



    [Header("값")]
    [SerializeField] string playerName;
    [SerializeField] int level;
    [SerializeField] int exp;

    int requireExp;

    private void Start()
    {
        profileUI.Setup(playerName, level, exp, requireExp);
    }

    void Awake()
    {
        requireExp = RequireExp();
    }

    int RequireExp() => (int)(Mathf.Clamp(Mathf.Pow(level + 1, 2) + 1000, 1000, 10000));

    void LevelLimitCorrection()
    {
        level = MAX_LEVEL;
        exp = 0;

        profileUI.UpdateLevel(level);
        profileUI.UpdateExp(exp, requireExp);
    }

    public void UpdateName(string _name)
    {
        playerName = _name;

        profileUI.UpdateName(playerName);
    }

    public void UpdateLv(int _lv = 0)
    {
        if (_lv == 0)
            level++;
        else
            level += _lv;

        profileUI.UpdateLevel(level);

        if (level >= MAX_LEVEL)
            LevelLimitCorrection();
    }

    public void UpdateExp(int _exp)
    {
        if (level >= MAX_LEVEL)
            LevelLimitCorrection();

        exp += _exp;

        while (true)
        {
            if (exp > requireExp)
            {
                Debug.Log($"현재레벨:{level} / 현재경험치:{exp} / 필요경험치:{requireExp}");

                exp -= requireExp;
                UpdateLv();
                requireExp = RequireExp();

                Debug.Log($"{level}로 레벨업 / 현재경험치:{exp}");
            }
            else
                break;
        }

        profileUI.UpdateExp(exp, requireExp);

        if (level >= MAX_LEVEL)
            LevelLimitCorrection();
    }
}
