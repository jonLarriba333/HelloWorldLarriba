using Unity.Burst.Intrinsics;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Progress;

public class ColourTheWorld : MonoBehaviour
{
    public Color colour = Color.white;
    [SerializeField]
    private UnityEngine.Object[] allTheGameObjectsList;

    [SerializeField]
    private UnityEngine.Object[] tagItems;

    public bool findBlue;
    public bool findRed; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
       allTheGameObjectsList = FindObjectsByType<MeshRenderer>(FindObjectsSortMode.None); //This finds every object that has a mesh renderer inside.
    }

    // Update is called once per frame
    void Update()
    {
        if (findBlue == true && findRed == false)
        {
            tagItems = GameObject.FindGameObjectsWithTag("Ao"); //Includes in the list every single object with blue tag
        }
        else if (findRed == true && findBlue == false)
        {
            tagItems = GameObject.FindGameObjectsWithTag("Aka"); // Includes in the list every single object with red tag
        }
        else if (findRed == false && findBlue == false)
        {
            tagItems = null;
        }
        else
        {
            tagItems = FindObjectsByType<MeshRenderer>(FindObjectsSortMode.None); //This finds every object that has a mesh renderer inside.

        }


        for (int i = 0; i < allTheGameObjectsList.Length; i++)
            {
                tagItems[i].GetComponent<MeshRenderer>().material.color = colour; //This paints every single GameObject
            }
    }
}
