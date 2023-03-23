using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    public GameObject targetObject; // the object to check for proximity
    public float proximityDistance = 2f; // the distance at which to trigger the position change
    public float newPositionY = 5f; // the new y position for the object
    public float animationSpeed = 1f; // the speed of the animation
    private Vector3 targetPosition; // the target position for the flag
    private bool rising = false; // flag to indicate if the flag should rise

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, targetObject.transform.position);

        // if the distance is less than or equal to the proximity distance, set the target position and the rising flag
        if (distance <= proximityDistance && !rising)
        {
            targetPosition = new Vector3(transform.position.x, transform.position.y + newPositionY, transform.position.z);
            rising = true;
        }

        // If the flag is set to rise, smoothly interpolate the position
        if (rising)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, animationSpeed * Time.deltaTime);
        }
    }
}

