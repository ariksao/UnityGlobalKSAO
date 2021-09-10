using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kliks : StateMachineBehaviour
{
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        // Detect if the left mouse button is down
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay
               (Input.mousePosition);
            RaycastHit raycastHit;

            if (Physics.Raycast(ray, out raycastHit, 100))
            {
                // get the collider, which was hit by the ray
                var colliderHit = raycastHit.collider;
                // get the game object the collider is attached to
                var gameObjectHit = colliderHit.gameObject;

                // get the gameObjects animator
                var animator =
                   gameObjectHit.GetComponent<Animator>();

                // play the animation
                animator.Play("Kikkareanimaatio");
            }
        }
    }
}
