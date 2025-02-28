using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
    public float boost;
    

    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().speed *= boost;
        other.GetComponent<FirstPersonMovement>().runSpeed *= boost;
    }
    void OnTriggerExit(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().speed /= boost;
        other.GetComponent<FirstPersonMovement>().runSpeed /= boost;
    }

}
