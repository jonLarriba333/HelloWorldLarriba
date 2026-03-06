using Unity.Burst.Intrinsics;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Progress;

public class ColourTheWorld : MonoBehaviour
{
    public Color colour = Color.white;
    [SerializeField]
    private UnityEngine.Object[] allTheGameObjectsList;

    public bool findBlue;
    public bool findRed; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (findBlue==true && findRed == false)
        {
            allTheGameObjectsList = GameObject.FindGameObjectsWithTag("Ao");
        }
        else if (findRed==true && findBlue == false)
        {
            allTheGameObjectsList = GameObject.FindGameObjectsWithTag("Aka");
        }
        else if (findRed == false && findBlue == false)
        {
            Debug.Log("Nothing");
        }
        else
        {
            allTheGameObjectsList = FindObjectsByType<MeshRenderer>(FindObjectsSortMode.None);
        }


    }

    // Update is called once per frame
    void Update()
    {
      //  for (int i = 0; i < allTheGameObjectsList.Length; i++)
       // {
       //     if (allTheGameObjectsList[i].GetComponent<MeshRenderer>())
         //   {
           //     if (GameObject (allTheGameObjectsList[i].) == "Aka")
             //   {
            //        allTheGameObjectsList[i].GetComponent<MeshRenderer>().material.color = Color.red;
             //   }
           //     else if (allTheGameObjectsList[i].GetComponent<GameObject>().tag == "Ao")
             //   {
               //     allTheGameObjectsList[i].GetComponent<MeshRenderer>().material.color = Color.blue;
           //     }
             //  // allTheGameObjectsList[i].GetComponent<MeshRenderer>().material.color = colour;
            //}
        //}
    }
}
