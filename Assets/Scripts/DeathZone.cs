using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        CharacterController control = other.gameObject.GetComponent<CharacterController>();
        if(control != null)
        {
            control.Died();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
