using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Aaaa.Anjay;
using Greanox;
using TMPro;
public class GameManager : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;
    private void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();

    }
    public void ShowMessage()
    {
        Boss monster = new Boss();
        monster.Name = "jaka";
        monster.PointValue = 1000;

        monster = null;
/*        Alien alien = new Alien();
        alien.HP = 100;

        Alien alien2 = alien;
        alien2.HP = 150;
        Debug.Log($"Alien 1 HP :  {alien.HP}");
        Debug.Log($"Alien 2 HP :  {alien2.HP}");
        
        Player PlayerOne = new Player();
        PlayerOne.Name = "Dipo";
        Player PlayerTwo = PlayerOne;
        PlayerTwo.Name = "Tomo";
        Debug.Log($"Player 1 name :  {PlayerOne.Name}");
        Debug.Log($"Player 2 name :  {PlayerTwo.Name}");

        PlayerOne = null;
        Debug.Log($"Player 2 name :  {PlayerTwo.Name}");*/
    }
/*    private TextMeshProUGUI textMeshPro;
    private IShootable[] enemies = new IShootable[4];
    private Ipersitable[] saved =  new Ipersitable[3];
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        Alien alienOne = new Alien();
*//*        Alien alienTwo = new Alien();
        Alien alienThree = new Alien();*//*
        Turret turret = new Turret();
        Player player = new Player();

        *//*        enemies[0] = alienOne;*/
        /*       enemies[1] = alienTwo;
                enemies[2] = alienThree;*/
        /*        enemies[3] = turret;*//*
        saved[0] = player;
        saved[1] = alienOne;
        saved[2] = turret; 


    }

    public void ShowMessage()
    {
        foreach  (Ipersitable saveddata in saved) {
            saveddata.Save();
        }
*//*        foreach (IShootable shootable in enemies)
        {
            shootable.Fire();
        }*//*
    }*/
}

