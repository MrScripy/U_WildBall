using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitApplicationButton : MonoBehaviour
{
    private Button _button;

    private void Awake() => _button = GetComponent<Button>();

    private void OnEnable() => _button.onClick.AddListener(Exit);

    private void OnDisable() => _button.onClick.RemoveListener(Exit);

    private void Exit() => Application.Quit();
}
