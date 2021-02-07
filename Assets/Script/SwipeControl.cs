using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeControl : MonoBehaviour
{
    public GameObject scrollBar;
    float scrolPos =0;
    float[] pos;
    int posisi=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Next()
    {
        if (posisi < pos.Length - 1)
        {
            posisi += 1;
            scrolPos = pos[posisi];
        }
    }

    public void Back()
    {
        if (posisi >0)
        {
            posisi -= 1;
            scrolPos = pos[posisi];
        }
    }


    // Update is called once per frame
    void Update()
    {
        pos = new float[transform.childCount];
        float distance = 1f / (pos.Length - 1f);

        for(int i = 0;i< pos.Length; i++)
        {
            pos[i] = distance * i;
        }


        if (Input.GetMouseButton(0))
        {
            scrolPos = scrollBar.GetComponent<Scrollbar>().value;
        }
        else
        {
            for(int i = 0; i < pos.Length; i++)
            {
                if (scrolPos < pos[i] + (distance / 2) && scrolPos > pos[i] - (distance / 2))
                {
                    scrollBar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollBar.GetComponent<Scrollbar>().value, pos[i], 1.5f);
                    posisi = i;
                }
            }
        }
        
    }
}
