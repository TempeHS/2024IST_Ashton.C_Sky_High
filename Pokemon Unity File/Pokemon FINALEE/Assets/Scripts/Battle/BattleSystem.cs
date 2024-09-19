using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BattleState { Start, PlayerAction, PlayerMove, EnemyMove, Busy }

public class BattleSystem : MonoBehaviour
{
    [SerializeField] private BattleUnit playerUnit;
    [SerializeField] private BattleUnit enemyUnit;
    [SerializeField] private BattleHud playerHud;
    [SerializeField] private BattleHud enemyHud;
    [SerializeField] private BattleDialogBox dialogBox;

    private BattleState state;
    int currentAction;

    private void Start()
    {
        StartCoroutine(SetupBattle());  // Fixed the StartCoroutine typo
    }

    private IEnumerator SetupBattle()
    {
        // Initial setup for the player and enemy Pokémon
        playerUnit.Setup();
        enemyUnit.Setup();

        // Set HUD data for player and enemy units
        playerHud.SetData(playerUnit.pokemon);
        enemyHud.SetData(enemyUnit.pokemon);

        // Show the introductory dialog for battle
        yield return dialogBox.TypeDialog($"A wild {enemyUnit.pokemon.Base.Name} appeared!");
        yield return new WaitForSeconds(1f);  // Wait for 1 second before proceeding to the next dialog

        // Show the player action dialog
        yield return dialogBox.TypeDialog($"Go, {playerUnit.pokemon.Base.Name}!");

        // Wait for 1 second before transitioning to the PlayerAction state
        yield return new WaitForSeconds(1f);

        // Move to Player Action state
        PlayerAction();
    }

    void PlayerAction()
    {
        state = BattleState.PlayerAction;
        StartCoroutine(dialogBox.TypeDialog("Choose an action"));
        dialogBox.EnableActionSelector(true);
    }

    
}