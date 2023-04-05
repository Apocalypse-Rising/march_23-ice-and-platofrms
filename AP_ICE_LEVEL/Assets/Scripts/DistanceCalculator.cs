using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceCalculator : MonoBehaviour
{
    public GameObject object1; // The first object
    public GameObject object2; // The second object
    public TextMesh textMesh; // The TextMesh object to display the distance

    // Update is called once per frame
    void Update()
    {
        float y1 = object1.transform.position.y;
        float y2 = object2.transform.position.y;
        float distance = Mathf.Abs(y1 - y2); // Calculate the distance between the y-coordinates
        distance = Mathf.Floor(distance);
        
        // Display the distance in the TextMesh
        textMesh.text = "Hazard: " + distance.ToString() + "ft AWAY";
    }
}
