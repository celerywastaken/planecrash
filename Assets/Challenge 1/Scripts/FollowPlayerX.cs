using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public Transform plane;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - plane.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = plane.transform.position + offset;
    }
}
