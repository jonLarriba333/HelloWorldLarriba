using UnityEngine;

public class HelloMyBrother : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello, this is: " + this.name);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Miau");
    }
}
