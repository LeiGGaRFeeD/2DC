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

    private void OnCollisionEnter2D(Collision2D collision) //���� ������ ��������
    {
        if(collision.gameObject.GetComponent<PlayerMovement>() == true) //���� ������ �����
        {
            Scene currentScene = SceneManager.GetActiveScene(); //�������� �������� �����
            string sceneName = currentScene.name; //���������� � ����������

            // ������������� �����
            SceneManager.LoadScene(sceneName);
        }
    }

}
