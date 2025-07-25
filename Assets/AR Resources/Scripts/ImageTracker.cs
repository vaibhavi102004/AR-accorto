using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ImageTracker : MonoBehaviour
{
    [SerializeField] private ARTrackedImageManager imageManager;
    [SerializeField] private GameObject[] arObjects;

    private List<GameObject> spawnedARObjects = new List<GameObject>();

    private void OnEnable()
    {
        imageManager.trackedImagesChanged += HandleChangedImage;
    }

    private void OnDisable()
    {
        imageManager.trackedImagesChanged -= HandleChangedImage;
    }

    private void HandleChangedImage(ARTrackedImagesChangedEventArgs args)
    {
        foreach (var image in args.added)
        {
            foreach (var prefab in arObjects)
            {
                if (image.referenceImage.name == prefab.name)
                {
                    GameObject newPrefab = Instantiate(prefab, image.transform);
                    newPrefab.name = prefab.name;
                    spawnedARObjects.Add(newPrefab);
                }
            }
        }

        foreach (var image in args.updated)
        {
            foreach (var prefab in spawnedARObjects)
            {
                if (prefab.name == image.referenceImage.name)
                {
                    prefab.SetActive(image.trackingState == TrackingState.Tracking);
                }
            }
        }
    }
}
