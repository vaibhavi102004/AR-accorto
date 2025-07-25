using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor; // Required for SceneAsset
#endif

public class BackNavigation : MonoBehaviour
{
#if UNITY_EDITOR
    public SceneAsset previousScene; // Reference a SceneAsset in the Inspector
#endif

    private string previousSceneName; // Resolved scene name

    void Start()
    {
#if UNITY_EDITOR
        if (previousScene != null)
        {
            previousSceneName = previousScene.name; // Resolve the scene name from the SceneAsset
        }
#endif
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Back Button Pressed");
            if (!string.IsNullOrEmpty(previousSceneName))
            {
                SceneManager.LoadScene(previousSceneName);
            }
            else
            {
                Debug.LogWarning("Previous scene is not set!");
            }
        }
    }
}
