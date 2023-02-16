using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    [SerializeField] GameObject MainMenu;
    [SerializeField] GameObject pauseCanvas;

    public void OnClick()
    {
        MainMenu.SetActive(false);
        pauseCanvas.SetActive(true);
    }

}
