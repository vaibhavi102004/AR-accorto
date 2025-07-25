using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HomeManager : MonoBehaviour
{
    public Button ScanButton;
    public Button QuitButton;
    public Button GlassButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ScanButton.onClick.AddListener(OnScanButtonClicked);
        QuitButton.onClick.AddListener(OnQuitButtonClicked);
        GlassButton.onClick.AddListener(OnGlassButtonClicked);
    }

    // Update is called once per frame
    public void OnScanButtonClicked()
    {
        Debug.Log("Scan Button Pressed");
        SceneManager.LoadScene("SampleScene");
    }

    public void OnQuitButtonClicked()
    {
        Debug.Log("Quit Button Pressed");
        Application.Quit();
    }

    public void OnGlassButtonClicked()
    {
        Debug.Log("Glass Button Pressed");
        SceneManager.LoadScene("GlassScene");
    }
}
