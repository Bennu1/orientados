using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conta : MonoBehaviour
{

    public Text contador;
    private float tiempo = 60f;
    public Image fin;
    public Text uno;
    public Text dos;
    public Text tres;


    // Start is called before the first frame update
    void Start()
    {
        contador.text = " " + tiempo;
        fin.enabled = false;
        uno.enabled = false;
        dos.enabled = false;
        tres.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        tiempo -= Time.deltaTime;
        contador.text = " " + tiempo.ToString("f0");

        if(tiempo <= 0)
        {
            contador.text = "0";
            fin.enabled = true;
            uno.enabled = true;
            dos.enabled = true;
            tres.enabled = true;
        }
    }
}
