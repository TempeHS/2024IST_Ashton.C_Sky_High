using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleUnit : MonoBehaviour
{
    [SerializeField] private PokemonBase _base;  // Private serialized field
    [SerializeField] private int level;
    [SerializeField] private bool isPlayerUnit;  // Bool to check if this is the player's unit

    public Pokemon pokemon { get; set; }

    public void Setup()
    {
        pokemon = new Pokemon(_base, level);

        // Set the sprite based on whether it's a player unit or not
        if (isPlayerUnit)
        {
            GetComponent<Image>().sprite = pokemon.Base.BackSprite;  
        }
        else
        {
            GetComponent<Image>().sprite = pokemon.Base.FrontSprite; 
        }
    }
}
