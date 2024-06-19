using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) //Если объект касается
    {
        if(collision.gameObject.GetComponent<PlayerMovement>() == true) //Если объект игрок
        {
            Scene currentScene = SceneManager.GetActiveScene(); //Получаем активную сцену
            string sceneName = currentScene.name; //Записываем в переменную

            // Перезагружаем сцену
            SceneManager.LoadScene(sceneName);
        }
    }

}
