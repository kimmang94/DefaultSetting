using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInstantiate : MonoBehaviour
{
    
    void Start()
    {
       GameObject obj =  Managers.Resource.Instantiate("Prefabs/Capsule");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
