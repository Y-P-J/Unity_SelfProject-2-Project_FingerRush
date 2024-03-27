using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DebugUI : MonoBehaviour
{
    [Header("������Ʈ")]
    [SerializeField] TMP_Text debugActivateText;



    [Header("��")]
    bool isActivate;



    #region ����
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

        Debug.Log($"{gameObject.name}({GetType()}) / ����׸�� {isActivate}");
    }
}
//Debug.Log($"{gameObject.name}({GetType()}) / [����]");
