using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private Renderer cuberenderer;
    // Start is called before the first frame update
    void Start()
    {
        cuberenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        cuberenderer.material.color = new Color(Random.value, Random.value, Random.value);
    }
}
