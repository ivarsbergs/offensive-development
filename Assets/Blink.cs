using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{

    void Start()
    {
        InvokeRepeating("ToggleActive", 1, 1);
    }

    public void ToggleActive()
    {
        this.gameObject.SetActive(!this.gameObject.activeSelf);
    }
}
