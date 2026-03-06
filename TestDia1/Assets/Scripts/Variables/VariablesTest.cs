using UnityEngine;

public class VariablesTest : MonoBehaviour
{
    public int publicVar;
    private int nonPublicIMeanPrivateVarForNow;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(publicVar);
        publicVar = 32;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(publicVar);
    }
}
