using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] string playScene = "Overworld";

    [Tooltip("Drag in an options menu panel, if one exists")]
    [SerializeField] GameObject optionsMenuPanel;
    [SerializeField] GameObject optionsCloseButton;
    [SerializeField] GameObject optionsOpenButton;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void OptionsMenuClose()
    {
        EventSystem.current.SetSelectedGameObject(optionsOpenButton);
        optionsMenuPanel.SetActive(false);
    }

    public void OptionsMenuOpen()
    {
        optionsMenuPanel.SetActive(true);
        EventSystem.current.SetSelectedGameObject(optionsCloseButton);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(playScene);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT GAME");
        Application.Quit();
    }
}