using UnityEngine;

public class MovingCapsule : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CapsuleMover();
    }

    void CapsuleMover()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.transform.position = gameObject.transform.position + Vector3.forward;
            Debug.Log(gameObject.transform.position);
        }
    }
}
