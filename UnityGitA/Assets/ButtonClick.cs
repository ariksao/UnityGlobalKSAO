using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;


public class ButtonClick : MonoBehaviour
{
  
        int n;
        public void OnButtonPress()
        {
            n++;
            Debug.Log("Button clicked " + n + " times.");

        }
    
}
