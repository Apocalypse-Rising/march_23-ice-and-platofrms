using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchYCoordinate : MonoBehaviour
{
    public GameObject targetObject; // The object whose y-coordinate will be matched

    // Update is called once per frame
    void Update()
    {
        float targetY = targetObject.transform.position.y;

        // Set the current object's y-coordinate to be the same as the target object's y-coordinate
        transform.position = new Vector3(transform.position.x, targetY, transform.position.z);
    }
}