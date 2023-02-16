using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject mainMenuCanvas;
    [SerializeField] GameObject levelsCanvas;

    private void Start()
    {
        mainMenuCanvas.SetActive(true);
        levelsCanvas.SetActive(false);
    }

    public void OnStartButtonClick()
    {
        mainMenuCanvas.SetActive(false);
        levelsCanvas.SetActive(true);
    }

    public void OnMainMenuButtonClick()
    {
        levelsCanvas.SetActive(false);
        mainMenuCanvas.SetActive(true);
    }

    public void OnLevelButtonClick(int num)
    {
        SceneManager.LoadScene(num);
    }
}
