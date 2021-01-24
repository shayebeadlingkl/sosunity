using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class representing a Character in the game
// Used in and out of combat
public class Character : MonoBehaviour
{
    private string characterName;
    private Sprite sprite;
    private float hp;
    private float attack;
    private float defense;
    private float spellcasting; 
    private float speed;
    private float spellDefense;
    private float evasion;
    private int numActions;
    private List<Ability> abilities;

    public string getCharacterName () { return this.characterName; }
    public Sprite getSprite () { return this.sprite; }
    public float getHp () { return this.hp; }
    public float getAttack () { return this.attack; }
    public float getDefense () { return this.defense; }
    public float getSpellcasting () { return this.spellcasting; }
    public float getSpeed () { return this.speed; }
    public float getSpellDefense () { return this.spellDefense; }
    public float getEvasion () { return this.evasion; }
    public int getNumActions () { return this.numActions; }
    public List<Ability> getAbilities () { return this.abilities; }

    public void SetSprite (Sprite sprite) {
        this.sprite = sprite;
    }

    public void SetTarget () {
       
    }
}
