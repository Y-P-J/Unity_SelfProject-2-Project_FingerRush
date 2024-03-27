using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugUIController : MonoBehaviour
{
    [Header("컴포넌트")]
    DebugUI debugUI;

    void Start()
    {
        debugUI = GetComponentInChildren<DebugUI>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.W) && Input.GetKeyDown(KeyCode.M))
            debugUI.gameObject.SetActive(!debugUI.gameObject.activeSelf);

        if (!debugUI.gameObject.activeSelf)
            return;

        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.W) && Input.GetKeyDown(KeyCode.J))
            debugUI.UpdateIsActivate();

        if (!debugUI.IsActivate)
            return;

        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.W) && Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log($"{gameObject.name}({GetType()}) / 디버그로 경험치 1000 증가");
            PlayerManager.Instance.UpdateExp(1000);
        }

        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.W) && Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log($"{gameObject.name}({GetType()}) / 디버그로 경험치 10000 증가");
            PlayerManager.Instance.UpdateExp(10000);
        }
    }
}
