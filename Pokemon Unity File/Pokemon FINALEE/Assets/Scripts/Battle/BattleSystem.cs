using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    [SerializeField] private BattleUnit playerUnit;
    [SerializeField] private BattleUnit enemyUnit;
    [SerializeField] private BattleHud playerHud;
    [SerializeField] private BattleHud enemyHud;
    [SerializeField] private BattleDialogBox dialogBox;

    private void Start()
    {
        SetupBattle();
    }

    private void SetupBattle()
    {
        playerUnit.Setup();
        enemyUnit.Setup();
        playerHud.SetData(playerUnit.pokemon);
        enemyHud.SetData(enemyUnit.pokemon);

        // Display battle start dialog
        StartCoroutine(StartBattleDialog());
    }

    private IEnumerator StartBattleDialog()
    {
        // Display message for the wild enemy appearing
        yield return dialogBox.TypeDialog($"A wild {enemyUnit.pokemon.Base.Name} appeared!");

        // Display message for the player's Pokémon being sent out
        yield return dialogBox.TypeDialog($"Go, {playerUnit.pokemon.Base.Name}!");
    }
}
