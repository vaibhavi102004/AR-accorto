using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ServicesManager : MonoBehaviour
{
    public Button HomeButton;
    public Button ServicesButton;
    public Button ProfileButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HomeButton.onClick.AddListener(OnHomeButtonClicked);
    }

    // Update is called once per frame
    public void OnHomeButtonClicked()
    {
        Debug.Log("Home Button Pressed");
        SceneManager.LoadScene("HomeScene");
    }


}
