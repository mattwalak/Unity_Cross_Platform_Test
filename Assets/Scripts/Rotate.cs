using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public AudioSource audioSource;
    
    private float ROT_SPEED = 180; // deg per sec


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, ROT_SPEED 
        * Time.deltaTime));

        if(Input.GetMouseButtonDown(0)){
            audioSource.Play();
        }
    }
}
