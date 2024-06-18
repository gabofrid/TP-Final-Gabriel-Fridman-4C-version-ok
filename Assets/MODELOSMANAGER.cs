using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MODELOSMANAGER : MonoBehaviour
{
    public GameObject[] modelos;
    public int currentIndex = -1;
    // Start is called before the first frame update
    void Start()
    {
        DeactivateAll();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
            currentIndex++;
        {
            if (currentIndex < modelos.Length)
            {
                ActivatebyIndex(currentIndex);
                DeActivatebyIndex(currentIndex);
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
            currentIndex--;
        {
            if (currentIndex < modelos.Length)
            {
                ActivatebyIndex(currentIndex);
                DeActivatebyIndex2(currentIndex);
            }
        }
    }

    void DeactivateAll ()
    {
        for ( int i = 0; i< modelos.Length; i++)
        {
            modelos[i].SetActive(false);
        }
    }

    void ActivatebyIndex( int index)
    {
        modelos[index].SetActive(true);
    }

    void DeActivatebyIndex(int index)
    {
        modelos[index - 1].SetActive(false);
    }

    void DeActivatebyIndex2(int index)
    {
        modelos[index + 1].SetActive(false);
    }
}
