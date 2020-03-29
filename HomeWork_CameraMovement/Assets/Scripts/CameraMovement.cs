using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    
    //Hook the GameObject
    public GameObject player;

    private Vector3 offset;

    [SerializeField] 
    private float smoothSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        /*If you want to see smooth camera movement comment next line and uncomment the rest*/
        transform.position = player.transform.position + offset;
        
        // Thanks to Brackeys 
        /*
        Vector3 desiredPosition = player.transform.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;
        */
    }
}
