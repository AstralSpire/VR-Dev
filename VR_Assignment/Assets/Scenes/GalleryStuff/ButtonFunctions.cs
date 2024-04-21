using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFunctions : MonoBehaviour
{

    public GameObject flower1;
    public GameObject F1button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Flower1()
    {
        flower1.SetActive(true);
        F1button.SetActive(false);
    }
}
