using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
public void Escena1()
    {
        SceneManager.LoadScene(1);
    }
    public void Escena2()
    {
        SceneManager.LoadScene(2);
    }
    public void Escena3()
    {
        SceneManager.LoadScene(3);
    }
    public void QuitarJuego()
    {
        Application.Quit();
        Debug.Log("Saliendo de aplicacion");

    }
}
