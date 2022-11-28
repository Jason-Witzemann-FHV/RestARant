using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceObject : MonoBehaviour
{
    [SerializeField] private Transform _tracker;

    // Update is called once per frame
    void Update()
    {
        if (_tracker != null)
        {
        transform.position = _tracker.position;
        }
    }
}
