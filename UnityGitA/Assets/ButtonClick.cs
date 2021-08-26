using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;


public class ButtonClick : MonoBehaviour
{
    public GameObject kuutio;
    int n;
    int x, y, z;

        public void OnButtonPress()
        {
        
        n++;
        x = Random.Range(0, -80);
        y = Random.Range(0, -30);
  
        Debug.Log("Button clicked " + n + " times.");

        transform.localPosition = new Vector2(x,y);
        
        }
    
}
