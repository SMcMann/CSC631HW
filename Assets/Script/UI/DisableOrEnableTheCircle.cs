using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableOrEnableTheCircle : MonoBehaviour
{
    public GameObject circle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisableOrEnable()
    {
        if (circle.activeInHierarchy == true)
        {
            circle.SetActive(false);
        }
        else
        {
            circle.SetActive(true);
        }
    }
}
