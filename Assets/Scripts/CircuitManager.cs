using UnityEngine;

public class CircuitManager : MonoBehaviour
{
    public Material OnSwitchMaterial;
    public Material OnBulbMaterial;
    public Material OffSwitchMaterial;
    public Material OffBulbMaterial;
    public Renderer switchRenderer;
    public Renderer bulbRenderer;
    public bool On;

    private Camera arCamera;

    void Start()
    {
        // Cache the AR camera reference
        arCamera = Camera.main;
    }

    void Update()
    {
        // Handle touch input
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Check for both Began and Ended phases to make it more responsive
            if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Ended)
            {
                Ray ray = arCamera.ScreenPointToRay(touch.position);
                RaycastHit hit;

                // Use LayerMask.GetMask("Default") if your object is on the Default layer
                if (Physics.Raycast(ray, out hit))
                {
                    // Check if we hit this object's collider
                    if (hit.collider.gameObject == gameObject)
                    {
                        ChangeMaterial();
                    }
                }
            }
        }
    }

    void ChangeMaterial()
    {
        // Toggle the state first
        On = !On;

        Debug.Log($"Switch state changed to: {On}");

        // Apply materials based on current state
        if (On)
        {
            bulbRenderer.material = OnBulbMaterial;
            switchRenderer.material = OnSwitchMaterial;
        }
        else
        {
            bulbRenderer.material = OffBulbMaterial;
            switchRenderer.material = OffSwitchMaterial;
        }
    }
}