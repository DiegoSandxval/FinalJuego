using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text ammoText;

    public Text healthText;
    // Start is called before the first frame update
 public static GameManager Instance { get; private set;  }
    public int gunAmmo = 10;

    public int health = 100;

    private void Awake()
    {

        Instance = this;
    }
    private void Update()
    {
        ammoText.text = gunAmmo.ToString();
        healthText.text = health.ToString();
    }
    public void LoseHealth(int healthToReduce)
    {
        health -= healthToReduce;
    }
    public void CheckHealth()
    {
        if (health <= 0)
        {
            Debug.Log("Has Muerto");

            SceneManager.LoadScene(4);
        }
    }
}


