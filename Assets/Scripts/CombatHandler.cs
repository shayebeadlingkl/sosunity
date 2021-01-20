using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class inspired by https://www.youtube.com/watch?time_continue=187&v=0QU0yV0CYT4&feature=emb_logo
/*
    TODO:
    Write Party class
    Change the Player and Enemy prefabs used to "party" prefabs that spawn all characters in each party
*/

public class CombatHandler : MonoBehaviour
{
    
    private Party playerParty;
    private Party enemyParty;
    private GameObject activeCharacter;

    public void Setup(Party playerParty, Party enemyParty) {
        this.playerParty = playerParty;
        this.enemyParty = enemyParty;
        this.activeCharacter = playerParty.GetParty()[0];
        InitCharacters();
    }

    private void Start() {

    }

    private void InitCharacters () {

    }

    private void OnAttackButton () {

    }

    private void OnDefendButton () {

    }

    private void OnSkillButton () {

    }

    private void OnRunButton () {

    }

}
