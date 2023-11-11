using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Greanox;
using Aaaa.Anjay;

public class Structs : MonoBehaviour
{
    Player PlayerOne;
    Alien Alien;
    Alien AlienTwo;
    private TextMeshProUGUI TextMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        TextMeshPro = GetComponent<TextMeshProUGUI>();
/*        PlayerOne = new Player(3, "Udin", 100);*/
/*        PlayerOne.Name = "Udin";
        PlayerOne.Lives = 3;

        int aScore = 100;
        PlayerOne.Score = aScore;*/
        
        Alien = new Alien(100, 50, true);
        AlienTwo = new Alien(1000, 100, false);
/*        Alien = new Alien();
        Alien.point = 100;
        Alien.HP = 50;
        Alien.Status = true;
        AlienTwo = new Alien();
        AlienTwo.point = 1000;
        AlienTwo.HP = 100;
        AlienTwo.Status = false;*/
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ShowMessage()
    {
/*        TextMeshPro.text = $"Nama : {PlayerOne.Name}. Score : {PlayerOne.Score}, lives : {PlayerOne.Lives}";*/
        TextMeshPro.text = $"Point : {Alien.point}. HP : {Alien.HP}, Status : {Alien.Status} Point : {AlienTwo.point}. HP : {AlienTwo.HP}, Alive : {AlienTwo.Status}";
    }
}
