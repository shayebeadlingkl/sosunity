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

    public void Setup(Party p, Party e) {
        this.playerParty = p;
        this.enemyParty = e;
        InitCharacters();
    }

    private void Start() {
    }

    private void InitCharacters () {
        List<Character> p = playerParty.GetParty();
        foreach (Character c in p) {
            //Instantiate(c, new Vector3(0, 0), Quaternion.identity, this.GetComponent<Transform>());
        }
        p = enemyParty.GetParty();
        foreach (Character c in p) {
        }
    }

     

}
