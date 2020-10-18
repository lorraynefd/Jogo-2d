using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Camera : MonoBehaviour

{   
    public float maximoX;
    
    public float minimoX;
    
    public float minimoY;
    
    public float maximoY;
 
    public Transform player; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(player.position.x, minimoX, maximoX), Mathf.Clamp(player.position.y, minimoY, maximoY),transform.position.z);
    }
}
