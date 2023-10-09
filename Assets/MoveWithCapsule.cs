using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithCapsule : MonoBehaviour
{
    public Vector3 offset;

    void Start()
    {
        offset = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
