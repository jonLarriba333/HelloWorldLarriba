using UnityEngine;
using UnityEngine.UIElements;

public class TrackerForCube : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ultimatePositionDetector();
    }

    private void ultimatePositionDetector()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Position in x: " + gameObject.transform.position.x + "Position in y: " + gameObject.transform.position.y); 
        }
        
    }
}
