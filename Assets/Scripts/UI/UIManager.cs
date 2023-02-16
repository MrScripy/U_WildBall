using UnityEngine;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
    public void OnMainMenuButtonClick()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void OnRestartLevelButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

}
