using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public class ARBackNavigation : MonoBehaviour
{
    public ARSession arSession;
    public string previousSceneName = "HomeScene";

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Back button detected in AR Session. Navigating to " + previousSceneName);
            if (arSession != null)
            {
                arSession.Reset(); // Or arSession.enabled = false;
            }
            SceneManager.LoadScene(previousSceneName);
        }
    }
}
