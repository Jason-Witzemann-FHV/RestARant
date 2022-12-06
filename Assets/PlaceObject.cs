using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceObject : MonoBehaviour
{
    [SerializeField] private Transform _tracker;
    [SerializeField] private GameObject _menuButtons;
    [SerializeField] private GameObject _trackerStartingGuide;

    // Update is called once per frame
    void Update()
    {
        if (IsTrackerVisible())
        {
            transform.position = _tracker.position;
        }
    }

    public bool IsTrackerVisible()
    {
        if (_tracker == null)
            return false;
        else
            return true;
            
    }

    public void InitialTrackerFound()
    {
        _menuButtons.SetActive(true);
        _trackerStartingGuide.SetActive(false);
    }
}
