using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum DamageType
{
    single = 1,
    duble = 2,
    quad = 4
}
public class Enumiration : MonoBehaviour
{
    public int Damage;
    public DamageType TotalDamage;
    private TextMeshProUGUI TextMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        TextMeshPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowMessage()
    {
        TextMeshPro.text = $"Your damage is {(int)TotalDamage * Damage}";
    }
}
