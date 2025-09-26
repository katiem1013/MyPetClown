using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDetection : MonoBehaviour
{
      private Practice manager;

        void Awake()
        {
            manager = FindObjectOfType<Practice>(); // Find the script in the scene
        }

        void OnMouseDown() // This is called when the object with a collider is clicked
        {
            if (manager != null)
            {
                manager.OnCircleClicked(); // Call the method in the manager script
            }
        }
}
