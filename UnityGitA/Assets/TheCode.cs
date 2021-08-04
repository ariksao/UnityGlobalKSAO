using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        // Debug.Log("Unity version 2020.1.16f1");
        Debug.Log("Unity version 2020.3.15f2 Personal");
    }


    int n;
    public void OnButtonPress()
    {
        n++;
        Debug.Log("Button clicked " + n + " times.");

    }


    // Update is called once per frame
    void Update()
    {
        // Rotates gameobject by its X -axis
        kikkare.transform.Rotate(0, kikkare_speed * Time.deltaTime, 0);

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A key pressed");
            kikkare_speed = kikkare_speed - kikkare_speed * 2;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("B key pressed");
            kikkare_speed = kikkare_speed + kikkare_speed * 2;
        }

        if (Input.GetKeyDown(KeyCode.C))

        {
            Debug.Log("(*C*) key pressed");
            kikkare_speed = 15;
        }
        ;

      // It worked..

    }
}