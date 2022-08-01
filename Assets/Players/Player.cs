using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public float speed = 25f;
    [SerializeField] float _speed = 8f;

    public Rigidbody _rigidbody;

    //private bool isVerticalPressed = false;
    

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        

    }
    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        Debug.Log(verticalInput);

        //isVerticalPressed = Input.GetButtonDown("Vertical");
          //  if (isVerticalPressed)
       // {
            _rigidbody.velocity = new Vector3( verticalInput, 0,  horizontalInput) * _speed;
        //}
    }

}

