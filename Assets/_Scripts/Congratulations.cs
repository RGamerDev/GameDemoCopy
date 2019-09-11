using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Congratulations : MonoBehaviour
{
    public GameObject Congrats;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Person"))
        {
            Congrats.SetActive(true);
            Debug.Log("Level completed");
            Application.Quit();
        }
    }
}
