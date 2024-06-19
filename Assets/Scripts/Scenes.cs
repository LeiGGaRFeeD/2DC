using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement; //�������� �� ��, ����� ����� ����� �������������

public class Scenes : MonoBehaviour
{
    void Start()
    {
        
    }
    public void GoToLevelOne()
    {
        Debug.Log("Go To Level 1"); //�������� � ������� ���������
        SceneManager.LoadScene("Level1"); //����������� �� �����
    }
    public void GoToLevelTwo()
    {
        Debug.Log("Go To Level 2"); //�������� � ������� ���������
        SceneManager.LoadScene("Level2"); //����������� �� �����
    }

    public void GoToLevelThree()
    {
        Debug.Log("Go To Level 3"); //�������� � ������� ���������
        SceneManager.LoadScene("Level3"); //����������� �� �����
    }

    public void GoToMainMenu()
    {
        Debug.Log("Go To MainMenu"); //�������� � ������� ���������
        SceneManager.LoadScene("MainMenu"); //����������� �� �����
    }

    public void GoToLevelSelect()
    {
        Debug.Log("Go To Level select"); //�������� � ������� ���������
        SceneManager.LoadScene("LevelSelect"); //����������� �� �����
    }
    void Update()
    {
        
    }
}
