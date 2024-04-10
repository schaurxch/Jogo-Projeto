using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float velocity = 15.0f;

    public float rotation = 300.0f;

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
       

        Vector3 dir = new Vector3(x, 0, y) * velocity;

        transform.Translate(dir*Time.deltaTime);

        transform.Rotate(new Vector3(0, mouseX * rotation * Time.deltaTime, 0));

       // transform.Rotate(new Vector3(mouseY * translation * Time.deltaTime, 0, 0));

        
    }
}
