using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rainbow : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    private float hue_t = 0.0f;
    private float hue_vel = 0.5f; // Full rotations per second


    // Update is called once per frame
    void Update()
    {
        hue_t += hue_vel * Time.deltaTime;
        hue_t = hue_t % 1.0f;
        meshRenderer.material.color = Color.HSVToRGB(hue_t, 1, 0.8f);
    }
}
