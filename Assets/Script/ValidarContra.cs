using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ValidarContra : MonoBehaviour
{
    string contracorrect;
    string contrausuario;
    public Text ingresoUsuario;

    // Start is called before the first frame update
    void Start()
    {
        contracorrect = "12345";
    }

    // Update is called once per frame
    public void ValidarContrasenia()
    {
        contrausuario = ingresoUsuario.text;
        if (contrausuario == contracorrect)
        {
            Debug.Log("Bienvenido");
        }
        else
        {
            Debug.Log("Contraseña incorrecta");
        }
    }
}
