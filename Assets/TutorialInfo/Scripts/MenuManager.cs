using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [Header("Menu Panels")]
    public GameObject welcomePanel;
    public GameObject instructionsPanel;
    public GameObject creditsPanel;

    [Header("Canvases")]
    public GameObject menuCanvas;
    public GameObject gameCanvas;

    [Header("Camera")]
    public GameObject gameCamera; // assign your Main Camera here

    void Start()
    {
        // Start with only WelcomePanel active
        ShowWelcomePanel();
        menuCanvas.SetActive(true);
        gameCanvas.SetActive(false);

        // Disable the camera at start
        if (gameCamera != null)
            gameCamera.SetActive(false);
    }

    private void HideAllPanels()
    {
        welcomePanel.SetActive(false);
        instructionsPanel.SetActive(false);
        creditsPanel.SetActive(false);
    }

    // === MENU NAVIGATION === //
    public void ShowWelcomePanel()
    {
        HideAllPanels();
        welcomePanel.SetActive(true);
    }

    public void ShowInstructionsPanel()
    {
        HideAllPanels();
        instructionsPanel.SetActive(true);
    }

    public void ShowCreditsPanel()
    {
        HideAllPanels();
        creditsPanel.SetActive(true);
    }

    // === GAME CONTROL === //
    public void StartGame()
    {
        // Hide all menu panels
        menuCanvas.SetActive(false);
        gameCanvas.SetActive(true);

        // Enable the camera
        if (gameCamera != null)
            gameCamera.SetActive(true);

        // Initialize GameManager
        if (GameManager.instance != null)
            GameManager.instance.StartGame();
    }

    public void ReturnToMenu()
    {
        // Disable the camera
        if (gameCamera != null)
            gameCamera.SetActive(false);

        // Switch canvases
        gameCanvas.SetActive(false);
        menuCanvas.SetActive(true);
        ShowWelcomePanel();
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
