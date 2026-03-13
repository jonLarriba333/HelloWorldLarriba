using UnityEngine;

public class CapsuleRotator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.T))
        {
            gameObject.transform.rotation *= Quaternion.Euler(1, 0, 0);
        }
        if (Input.GetKey(KeyCode.Y))
        {
            gameObject.transform.rotation *= Quaternion.Euler(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.U))
        {
            gameObject.transform.rotation *= Quaternion.Euler(0, 0, 1);
        }
    }
}
