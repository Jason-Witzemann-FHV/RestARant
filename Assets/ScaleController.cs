using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleController : MonoBehaviour
{
    [SerializeField] private GameObject resetButton;
    private Vector3 initialScale, originalScale;
    private float initialDistance;

    private void Start()
    {
        originalScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 2)
        {
            var touchZero = Input.GetTouch(0);
            var touchOne = Input.GetTouch(1);

            if (touchZero.phase == TouchPhase.Ended || touchZero.phase == TouchPhase.Canceled
               || touchOne.phase == TouchPhase.Ended || touchOne.phase == TouchPhase.Canceled)
            {
                return;
            }

            if (touchZero.phase == TouchPhase.Began || touchOne.phase == TouchPhase.Began)
            {
                // track the initial values
                initialDistance = Vector2.Distance(touchZero.position, touchOne.position);
                initialScale = transform.localScale;
            }
            else
            {
                //get the current distance
                var currentDistance = Vector2.Distance(touchZero.position, touchOne.position);

                // A little emergency brake ;)
                if (Mathf.Approximately(initialDistance, 0)) return;

                // get the scale factor of the current distance relative to the inital one
                var factor = currentDistance / initialDistance;

                transform.localScale = initialScale * factor;
                resetButton.SetActive(true);
            }
        }
    }

    public void resetScale()
    {
        transform.localScale = originalScale;
        resetButton.SetActive(false);
    }
}
