using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PindahMenu : MonoBehaviour
{
    public GameObject ini, itu;

    public void BTN()
    {
        ini.SetActive(false);
        itu.SetActive(true);
    }
}
