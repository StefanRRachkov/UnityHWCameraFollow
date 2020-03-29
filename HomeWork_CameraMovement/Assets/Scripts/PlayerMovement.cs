using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] 
    private float moveSpeed;
    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection = 
            moveSpeed 
            * Time.deltaTime 
            * new Vector3(Input.GetAxis("Horizontal"), 
                    0, 
                    Input.GetAxis("Vertical")) 
                .normalized;

        transform.position += moveDirection;

    }
}
