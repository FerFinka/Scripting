using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public int newJumpStrength = 10;
    void OnTriggerEnter(Collider other)

    {
        other.GetComponent<Jump>().jumpStrength += newJumpStrength;
    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength -= newJumpStrength;
    }
}
