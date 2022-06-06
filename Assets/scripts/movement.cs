using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float horizontalSpeed;
    float hor;
    void Start()
    {
        
    }

    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(hor * horizontalSpeed * Time.deltaTime, 0, movementSpeed * Time.deltaTime));    
        
    }
}
