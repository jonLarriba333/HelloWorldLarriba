using UnityEngine;

public class CapsuleEscalator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            gameObject.transform.localScale = gameObject.transform.localScale * 2;
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            gameObject.transform.localScale = gameObject.transform.localScale / 2;
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            gameObject.transform.localScale += Vector3.forward * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            gameObject.transform.localScale += Vector3.right * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Comma))
        {
            gameObject.transform.localScale += Vector3.back * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Colon))
        {
            gameObject.transform.localScale += Vector3.left * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            gameObject.transform.localScale += Vector3.up * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            gameObject.transform.localScale += new Vector3 (0, -1, 0) * Time.deltaTime;
        }
    }
}
