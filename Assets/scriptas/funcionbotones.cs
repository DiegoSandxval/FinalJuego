using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class funcionbotones : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void intentarDeNuevo (){
        SceneManager.LoadScene(4);

    }
    public void Salir (){
        SceneManager.LoadScene(0);
    }
}
