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
        playerHud.SetData(playerUnit.pokemon);
        enemyHud.SetData(enemyUnit.pokemon);

        // Show the introductory dialog for battle
        yield return dialogBox.TypeDialog($"A wild {playerUnit.pokemon.Base.Name} appeared!");
        yield return new WaitForSeconds(1f);  // Wait for 1 second before proceeding to the next dialog

    PlayerAction();
    }
    

    void PlayerAction()
    {
        state = BattleState.PlayerAction;
        StartCoroutine(dialogBox.TypeDialog("Choose an action"));
        dialogBox.EnableActionSelector(true);
    }

    
}
