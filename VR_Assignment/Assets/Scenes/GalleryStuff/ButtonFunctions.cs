using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{

    public GameObject f1 , f2, f3, cat, arcade, car, ship;
    public GameObject F1button , F2button, F3button, arcadebutton, catbutton , carbutton, shipbutton;
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
        f1.SetActive(true);
        F1button.SetActive(false);
    }

    public void Flower2()
    {
        f2.SetActive(true);
        F2button.SetActive(false);
    }
    public void Flower3()
    {
        f3.SetActive(true);
        F3button.SetActive(false);
    }
    public void Cat()
    {
        cat.SetActive(true);
        catbutton.SetActive(false);
    }
    public void Car()
    {
        car.SetActive(true);
        carbutton.SetActive(false);
    }
    public void Ship()
    {
        ship.SetActive(true);
        shipbutton.SetActive(false);
    }
     public void Arcade()
    {
        arcade.SetActive(true);
        arcadebutton.SetActive(false);
    }
    public void Play()
    {
        SceneManager.LoadScene("Test");
    }
}
