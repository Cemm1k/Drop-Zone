using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float speedOfScroll = 2f; // speed of parallax effect
    void Update()
    {
        MeshRenderer para = GetComponent<MeshRenderer>(); //gets texture of background
        Material material = para.material; //accessing material
        Vector3 offset = material.mainTextureOffset; //copy

        offset.x = transform.position.x / transform.localScale.x / speedOfScroll;
        offset.y = transform.position.y / transform.localScale.y / speedOfScroll; //background scrolling on different axis/ offset based on position/ background moves slower than the foreground
        offset.z = transform.position.z / transform.localScale.z / speedOfScroll;
        material.mainTextureOffset = offset;
    }
}
