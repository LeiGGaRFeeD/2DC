using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int CoinNominal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision works!");
        if (collision.gameObject.GetComponent<PlayerMovement>() == true)
        {
            Debug.Log("if works!");
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + CoinNominal); //��������� ������
            Destroy(gameObject); //���������� 

            //gameobject - ������ �� ������� ����� ������
            //collision.gameobject - ������, ������� �������� 
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
