using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SortUI : MonoBehaviour
{
    [SerializeField] TMP_Text selectedSortText;

    public void UpdateText(SORT_TYPE _type)
    {
        selectedSortText.text = _type switch
        {
            SORT_TYPE.A_Z => "�� ���� (A to Z)",
            SORT_TYPE.Z_A => "�� ���� (Z to A)",
            SORT_TYPE.LEVEL_LOW_HIGH => "���̵� (Low to High)",
            SORT_TYPE.LEVEL_HIGH_LOW => "���̵� (High to Low)",
            SORT_TYPE.BPM_LOW_HIGH => "BPM (Low to High)",
            SORT_TYPE.BPM_HIGH_LOW => "BPM (High to Low)",
            _ => "???",
        };

        if(selectedSortText.text == "???")
            Debug.Log($"{gameObject.name}({GetType()}) / ���� �̻���. �ڵ� �������");
    }
}
