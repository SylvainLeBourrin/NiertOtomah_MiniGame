using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacement2 : MonoBehaviour
{
    



    // Awake is called wheb tge script instance is being loaded
    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Start is called on the frame when a script is enabled just before any of the Update methods are called the first time.

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3();
        if (Input.GetKey(KeyCode.LeftArrow)) { 
            move.x -= 0.1f;

            transform.position += move;
        }



     

        
    }
}
