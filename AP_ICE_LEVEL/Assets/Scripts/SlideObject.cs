using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideObject : MonoBehaviour
{
    public float slideDistance = 1.0f; // distance to slide the object
    public float slideSpeed = 1.0f; // speed at which to slide the object

    private Vector3 targetPosition;

    void Start()
    {
        // calculate target position based on current position and slide distance
        targetPosition = transform.position + new Vector3(slideDistance, 0, 0);
    }

    void Update()
    {
        // move the object towards the target position at the specified speed
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, slideSpeed * Time.deltaTime);
    }
}