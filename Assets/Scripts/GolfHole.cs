using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolfHole : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
