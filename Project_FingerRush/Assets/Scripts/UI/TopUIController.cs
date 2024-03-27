using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopUIController : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F4))
            TrackManager.Instance.UpdateSortType();
    }
}
