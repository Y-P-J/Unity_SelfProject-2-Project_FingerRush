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
            SORT_TYPE.A_Z => "곡 제목 (A to Z)",
            SORT_TYPE.Z_A => "곡 제목 (Z to A)",
            SORT_TYPE.LEVEL_LOW_HIGH => "난이도 (Low to High)",
            SORT_TYPE.LEVEL_HIGH_LOW => "난이도 (High to Low)",
            SORT_TYPE.BPM_LOW_HIGH => "BPM (Low to High)",
            SORT_TYPE.BPM_HIGH_LOW => "BPM (High to Low)",
            _ => "???",
        };

        if(selectedSortText.text == "???")
            Debug.Log($"{gameObject.name}({GetType()}) / 값이 이상함. 코드 수정요망");
    }
}
