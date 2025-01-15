using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCenterer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /* Attach this script to all character models.
*  This script makes sure that when the charter enters the scene, 
*  it is centered inside its container.
*/
        transform.localPosition = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
