using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugUIController : MonoBehaviour
{
    [Header("������Ʈ")]
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
            Debug.Log($"{gameObject.name}({GetType()}) / ����׷� ����ġ 1000 ����");
            PlayerManager.Instance.UpdateExp(1000);
        }

        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.W) && Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log($"{gameObject.name}({GetType()}) / ����׷� ����ġ 10000 ����");
            PlayerManager.Instance.UpdateExp(10000);
        }
    }
}
