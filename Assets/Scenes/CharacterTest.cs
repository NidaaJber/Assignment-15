using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
public class CharacterTest : MonoBehaviour
{
    void Start()
    {
        Character[] characters = new Character[2];
        characters[0] = new Soldier(); 
        characters[1] = new Officer("Captain Smith", 90, new Position(5, 10, 15));

        for (int i = 0; i < characters.Length; i++)
        {
            characters[i].DisplayInfo();
        }

        Officer officer = characters[1] as Officer;
        Soldier soldier = characters[0] as Soldier;

        if (officer != null && soldier != null)
        {
            Debug.Log($"Soldier's Health before attack: {soldier.Health}");
            officer.Attack(30, soldier);
            Debug.Log($"Soldier's Health after attack: {soldier.Health}");
        }
    }
}
}
