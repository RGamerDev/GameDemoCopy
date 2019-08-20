using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    static AudioSource ticksource;

    private void Start()
    {
        ticksource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(new Vector3(0f, 1f, 0f));   
    }

    //private void OnDisable()
    //{
    //    ticksource.Play();
    //}
}
