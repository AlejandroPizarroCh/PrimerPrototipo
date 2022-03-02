using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{

    public float velocidad = 30;
    //public Transform referenciaDePosicion; 
    
    
    // Start is called before the first frame update
    void Start(){
        
    } 

    // Update is called once per frame
    void Update(){
       
        float horizontal = Input.GetAxis("Horizontal");  
        float vertical = Input.GetAxis("Vertical"); 
        transform.Translate(
            velocidad * horizontal * Time.deltaTime,
            velocidad * vertical * Time.deltaTime,
            0, 
            Space.World); 

    }
}
