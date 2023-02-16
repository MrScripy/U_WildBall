using UnityEngine;

public class PauseManager : MonoBehaviour
{
    [SerializeField] GameObject pausePanel;
    [SerializeField] GameObject coinsText;

    private void Start()
    {
        pausePanel.SetActive(false);        
        Time.timeScale = 1;
    }

    public void OnPauseButtonClick()
    {
        //add pause for the game
        pausePanel.SetActive(true);
        coinsText.SetActive(false);
        Time.timeScale = 0;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            OnPauseButtonClick();
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }
    }
    public void OnBackToGameButtonClick()
    {
        // add continuing game
        pausePanel.SetActive(false);
        coinsText.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
    }
}
