using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScanManager : MonoBehaviour
{
    public Button ExitButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ExitButton.onClick.AddListener(OnExitButtonClicked);
    }

    // Update is called once per frame
    public void OnExitButtonClicked()
    {
        Debug.Log("Exit Button Pressed");
        SceneManager.LoadScene("HomeScene");
    }


}
