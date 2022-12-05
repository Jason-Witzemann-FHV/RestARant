using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotationController : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch screenTouch = Input.GetTouch(0);

            if (screenTouch.phase == TouchPhase.Moved)
            {
                transform.Rotate(0f, -screenTouch.deltaPosition.x*rotationSpeed, 0f);
            }
        }
    }
}
