using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login_Manager : MonoBehaviour
{
    public InputField Contraseña;
    public string LaContra;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Escribir_Contraseña()
    {
        if (Contraseña.text == LaContra)
        {
            Debug.Log("Access Granted");
        }
        else
        {
            Debug.Log("Access Denied");
        }
    }
}
