using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snow : MonoBehaviour
{
    [Range(0.01f, 0.1f)]
    public float snowCoverSpeed;
    float value = 0;

    bool startSnowing = false;

    private void Start()
    {
        Shader.SetGlobalFloat("_SnowLevel", 0f);

    }
    private void Update()
    {
        startSnowing = true;
        if(startSnowing && value < 1f)
        {
            Shader.SetGlobalFloat("_SnowLevel", value);
            value += Time.deltaTime * snowCoverSpeed;
        }
    }
}
