using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class MyOperators : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayMessage()
    {
        int xp = 990;
        xp = xp + 10;
        xp += 10;
        xp -= 10; 
        xp *= 10;
        xp /= 10;

        int strength = 18;
        int stat = strength++;
        int div = 5 % 2;

        string firstName = "Dipo";
        string lastName = "Pratomo";
        string fullName = $"{firstName} {lastName}";

        int problem = 3 - 3 * 6 + 2;
        int multiplication = 3 * 6;
        int additional = 3;
        int solution = additional - multiplication + 2;

        float conversion = (float)100;
        int largeNumber = 1_000_000;
        byte smallnumber = (byte)largeNumber;
        textMeshPro.text = $"{smallnumber}";
    }
}
