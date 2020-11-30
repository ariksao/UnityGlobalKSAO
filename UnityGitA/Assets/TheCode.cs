using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheCode : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject kikkare;
    public float kikkare_speed;
    void Start()
    {
        Debug.Log("Testing Git!");
        Debug.Log("This line was added with Notepad++");
        Debug.Log("This line was added with Visual Studio 2019"); //Typo fixed
        Debug.Log("This line was added with Microsoft Notepad from another computer");
        Debug.Log("Testing New Visual Studio from remote PC");
        Debug.Log("This line was added from 3th workstation with Visual Studio");
    }

    // Update is called once per frame
    void Update()
    {
        // Rotates gameobject by its X -axis
        kikkare.transform.Rotate(0, kikkare_speed * Time.deltaTime, 0);
    }
}
