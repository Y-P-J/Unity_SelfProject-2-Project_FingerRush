using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProfileUI : MonoBehaviour
{
    [Header("ÄÄÆ÷³ÍÆ®")]
    [SerializeField] TMP_Text PlayerNameText;
    [SerializeField] TMP_Text levelText;
    [SerializeField] Slider expSlider;

    public void Setup(string _name, int _level, int _exp, int _requireExp)
    {
        UpdateName(_name);
        UpdateLevel(_level);
        UpdateExp(_exp, _requireExp);
    }

    public void UpdateName(string _name)
    {
        PlayerNameText.text = _name;
    }
    public void UpdateLevel(int _level)
    {

        levelText.text = _level.ToString();
    }
    public void UpdateExp(int _exp, int _requireExp)
    {
        expSlider.value = (float)_exp / (float)_requireExp;
    }
}
