using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   
    [SerializeField] float _speed = 8f;

    public Rigidbody _rigidbody;
    private Vector3 _mouvementInput;
    
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
       
        _mouvementInput = new Vector3(horizontal, 0, vertical); 
        
        
        
            

    }

}

