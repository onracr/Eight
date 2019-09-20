using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    GameObject player, startMenu, pauseMenu, optionsMenu;
    [SerializeField] Slider slider;
    
    private bool isEnabled = true;
    private bool isAlive = false;
    private Player playerComponent;

    void Start()
    {
        // player = GameObject.Find("Player");
        playerComponent = player.GetComponent<Player>();
    }

    void Update()
    {
        PauseMenu();
    }

    public void StartGame()
    {
        startMenu.SetActive(false);
        isAlive = true;
        Cursor.lockState = CursorLockMode.None;
        playerComponent.enabled = isEnabled;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = !isEnabled;
    }

    private void PauseMenu()
    {
        if (isAlive) {
            if (Input.GetKeyDown(KeyCode.Escape)) {
                ContinueGame();
            }
        }
    }
    
    public void ContinueGame()
    {
        isEnabled = !isEnabled;
        Cursor.visible = !isEnabled;
        pauseMenu.SetActive(!isEnabled);
        playerComponent.enabled = isEnabled;
    }

    public void OptionsMenu()
    {
        optionsMenu.SetActive(true);
        pauseMenu.SetActive(false);
    }

    public void BackFromOptionsMenu()
    {
        optionsMenu.SetActive(false);
        pauseMenu.SetActive(true);
    }

    public void ChangeMouseSensitivity()
    {
        playerComponent.lookSpeed = slider.value;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
