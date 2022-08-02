using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalker : MonoBehaviour
{
    //prendre la position actuel de l'objet "player"
    [SerializeField]Transform  _playerTransform;
    

    float speed = 3.0f;

    void awake()
    {
       
    }
    
    // Start is called before the first frame update
    void Start()
    {
        _playerTransform = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(new Vector3(_playerTransform.position.x, 0, _playerTransform.position.z));
        transform.Translate(-transform.forward * speed * Time.deltaTime);


       
    }
}
