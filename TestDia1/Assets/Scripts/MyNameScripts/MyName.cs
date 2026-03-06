using UnityEngine;

public class MyName : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("My name is: " + gameObject.name);
        Debug.Log("Las coordenadas del " + gameObject.name + " son: " + gameObject.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
