using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon
{
    private PokemonBase _base; // Made private to follow convention
    private int level;

    public int HP { get; set; }
    public List<Move> Moves { get; set; }

    public Pokemon(PokemonBase pBase, int pLevel)
    {
        _base = pBase;
        level = pLevel;
        HP = MaxHp; // Using MaxHp property to initialize HP

        // Generate moves
        Moves = new List<Move>();
        foreach (var move in _base.LearnableMoves)
        {
            if (move.Level <= level)
            {
                Moves.Add(new Move(move.MoveBase, move.MoveBase.PP)); // Correctly initialize PP
            }

            if (Moves.Count >= 4)
            {
                break;
            }
        }
    }

    public int Attack
    {
        get { return Mathf.FloorToInt(_base.Attack * level / 100f) + 5; }
    }

    public int Defense
    {
        get { return Mathf.FloorToInt(_base.Defense * level / 100f) + 5; }
    }

    public int SpAttack
    {
        get { return Mathf.FloorToInt(_base.SpAttack * level / 100f) + 5; }
    }

    public int SpDefense
    {
        get { return Mathf.FloorToInt(_base.SpDefense * level / 100f) + 5; }
    }

    public int Speed
    {
        get { return Mathf.FloorToInt(_base.Speed * level / 100f) + 5; }
    }

    public int MaxHp
    {
        get { return Mathf.FloorToInt(_base.MaxHp * level / 100f) + 10; }
    }
}
