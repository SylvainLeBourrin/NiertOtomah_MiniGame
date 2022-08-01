using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public float speed = 25f;
    [SerializeField] float _speed = 8f;

    public Rigidbody _rigidbody;
    private Vector3 _mouvementInput;
    //private bool isVerticalPressed = false;
    private void FixedUpdate()
    {
        Vector3 velocity;
        velocity = (_mouvementInput * _speed);
       _rigidbody.velocity = velocity;
         
    }

    // Start is called before the first frame update
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
       
        

    }
    // Update is called once per frame
   
    void Update()
    {
        float horizontal =  Input.GetAxisRaw("Horizontal");
        float vertical   =  Input.GetAxisRaw("Vertical");
        float orientationHorizontal = Input.
        //
        _mouvementInput = new Vector3(horizontal, 0, vertical); 
        //Vector3.Normalize("velocity");  //= ("horizontal", 0, "vertical");



        // float verticalInput = Input.GetAxis("Vertical");
        //float horizontalInput = Input.GetAxis("Horizontal");

        // Debug.Log(verticalInput);

        //isVerticalPressed = Input.GetButtonDown("Vertical");
        //  if (isVerticalPressed)
        // {
        //   _rigidbody.velocity = new Vector3( verticalInput, 0,  horizontalInput);
        //}
    }

}

