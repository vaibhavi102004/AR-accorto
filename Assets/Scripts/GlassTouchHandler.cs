using UnityEngine;

public class GlassTouchHandler : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        // Detect touches on the screen
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0); // Get the first touch
            if (touch.phase == TouchPhase.Began) // Check if the touch just started
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit)) // Perform a raycast to detect objects
                {
                    if (hit.transform == transform) // Check if this object was touched
                    {
                        PlaySound();
                    }
                }
            }
        }
    }

    void PlaySound()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }

    void OnMouseDown()
    {
        // Play the sound when the glass is clicked
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}
