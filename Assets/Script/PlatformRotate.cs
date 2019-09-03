using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRotate : MonoBehaviour
{
    public GameObject Platforms;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(new Vector3 { x = 0f, y = 0f, z = 1f});
    }
}
