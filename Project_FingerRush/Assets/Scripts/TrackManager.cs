using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SORT_TYPE
{
    A_Z,
    Z_A,
    LEVEL_LOW_HIGH,
    LEVEL_HIGH_LOW,
    BPM_LOW_HIGH,
    BPM_HIGH_LOW
}

public class TrackManager : Singleton<TrackManager>
{
    [Header("ÄÄÆ÷³ÍÆ®")]
    [SerializeField] SortUI sortUI;

    [Header("°ª")]
    SORT_TYPE sortType;

    void Start()
    {
        sortType = 0;
        UpdateSortType(false);
    }

    public void UpdateSortType(bool _changeSort = true)
    {
        if (_changeSort)
            sortType++;

        if ((int)sortType >= System.Enum.GetValues(typeof(SORT_TYPE)).Length)
            sortType = 0;

        sortUI.UpdateText(sortType);
    }
}
