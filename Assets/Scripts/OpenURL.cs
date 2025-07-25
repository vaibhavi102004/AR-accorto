using UnityEngine;

public class OpenURL : MonoBehaviour
{
    // The URL you want to open
    [SerializeField] private string url = "https://www.example.com";

    // Method to open the URL
    public void OpenLink()
    {
        Application.OpenURL(url);
    }
}
