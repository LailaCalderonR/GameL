using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Dispara");
        }
    }
}
