using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement; //Отвечает за то, чтобы сцены могли переключались

public class Scenes : MonoBehaviour
{
    void Start()
    {
        
    }
    public void GoToLevelOne()
    {
        Debug.Log("Go To Level 1"); //Выводить в консоль сообщение
        SceneManager.LoadScene("Level1"); //Перемещаюсь на сцену
    }
    public void GoToLevelTwo()
    {
        Debug.Log("Go To Level 2"); //Выводить в консоль сообщение
        SceneManager.LoadScene("Level2"); //Перемещаюсь на сцену
    }

    public void GoToLevelThree()
    {
        Debug.Log("Go To Level 3"); //Выводить в консоль сообщение
        SceneManager.LoadScene("Level3"); //Перемещаюсь на сцену
    }

    public void GoToMainMenu()
    {
        Debug.Log("Go To MainMenu"); //Выводить в консоль сообщение
        SceneManager.LoadScene("MainMenu"); //Перемещаюсь на сцену
    }

    public void GoToLevelSelect()
    {
        Debug.Log("Go To Level select"); //Выводить в консоль сообщение
        SceneManager.LoadScene("LevelSelect"); //Перемещаюсь на сцену
    }
    void Update()
    {
        
    }
}
