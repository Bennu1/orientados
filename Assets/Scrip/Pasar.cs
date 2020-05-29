using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pasar : MonoBehaviour
{
   
    public void PasarES(string nombre)
    {
        print("si");
        SceneManager.LoadScene(nombre);
    }
}
