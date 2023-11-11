using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MyVariable : MonoBehaviour
{
    private int health = 100;

    private int Health = 100;

    private int HeALTh = 100;

    private int myHealth = 100;
    private string messageForTheTextView = "This space for rent";
    private const int PlayerScore = 100;
    private const int PLAYER_SCORE = 100;
    public string firstName;
    public string lastName;

    private TextMeshProUGUI TextMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        TextMeshPro = GetComponent<TextMeshProUGUI>();
        TextMeshPro.text = $"Hello {firstName} {lastName}!"; 

    }

    // Update is called once per frame
    void Update()
    {
    }
}
