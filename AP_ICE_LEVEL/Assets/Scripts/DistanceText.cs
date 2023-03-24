using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceText : MonoBehaviour
{
    public GameObject targetObject; // the object to check for proximity
    public float proximityDistance = 2f; // the distance at which to trigger the position change
    public float slideDistance = 2f; // the distance to slide the object to the right
    public float slideSpeed = 2f; // the speed at which to slide the object to the right

    private Vector3 targetPosition;

    void Start()
    {
        // calculate target position based on current position and slide distance
        targetPosition = transform.position + new Vector3(slideDistance, 0f, 0f);
    }

    void Update()
    {
        // calculate the distance between this object and the target object
        float distance_b = targetObject.transform.position.y;
        float distance_a = transform.position.y - proximityDistance;

        // if the distance is less than or equal to the proximity distance, slide the object to the right
        if (distance_b >= distance_a)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, slideSpeed * Time.deltaTime);
        }
    }
}
