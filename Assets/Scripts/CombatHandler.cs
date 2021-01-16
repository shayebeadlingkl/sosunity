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

    public void Setup(Party playerParty, Party enemyParty) {
        this.playerParty = playerParty;
        this.enemyParty = enemyParty;
        InitCharacters();
    }

    private void Start() {
    }

    private void InitCharacters () {
        List<Character> party = playerParty.GetParty();
        foreach (Character character in party) {
            //Instantiate(char, new Vector3(0, 0), Quaternion.identity, this.GetComponent<Transform>());
        }
        party = enemyParty.GetParty();
        foreach (Character character in party) {
        }
    }

}
