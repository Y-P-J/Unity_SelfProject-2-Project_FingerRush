using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DebugUI : MonoBehaviour
{
    [Header("컴포넌트")]
    [SerializeField] TMP_Text debugActivateText;



    [Header("값")]
    bool isActivate;



    #region 람다
    public bool IsActivate => isActivate;
    #endregion



    void Start()
    {
        isActivate = false;
        debugActivateText.text = isActivate.ToString();
    }

    public void UpdateIsActivate()
    {
        isActivate = !isActivate;

        debugActivateText.text = isActivate.ToString();

        Debug.Log($"{gameObject.name}({GetType()}) / 디버그모드 {isActivate}");
    }
}
//Debug.Log($"{gameObject.name}({GetType()}) / [내용]");
