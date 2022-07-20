using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowController : MonoBehaviour
{
    [Range(0.01f, 0.1f)]
    public float snowCoverSpeed;
    float value = 0;

    private void Start()
    {
        Shader.SetGlobalFloat("_SnowLevel", 0f);
    }


    private void Update()
    {
        if (value < 1f)
        {
            Shader.SetGlobalFloat("_SnowLevel", value);
            value += Time.deltaTime * snowCoverSpeed;
        }
    }
}
