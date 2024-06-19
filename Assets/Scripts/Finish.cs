using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision) //Когда игрок соприкоснется 
    {
        if (collision.gameObject.GetComponent<PlayerMovement>() == true) //Если это игрок
        {
            Debug.Log("Ты финишировал!"); //Выводим в консоль
            SceneManager.LoadScene("LevelSelect");
        }
    }
}
