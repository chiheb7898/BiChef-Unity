using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixRotation : MonoBehaviour
{
    public Vector3 rotation;
    void Update()
    {
        transform.localEulerAngles = rotation;
    }
}
