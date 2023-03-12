using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] Button _BtnSwitchMorning;

    void Start()
    {
        Debug.Log("BtnSwitchMorning: " + _BtnSwitchMorning);
        _BtnSwitchMorning.onClick.AddListener(OnSwitchMorning);
    }

    private void OnSwitchMorning()
    {
        ScenesManager.instance.LoadScene(ScenesManager.Scene.Morning);
    }
}
