using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatSceneHandler : MonoBehaviour
{
    [SerializeField] private List<GameObject> m_pSprites;
    [SerializeField] private List<GameObject> m_eSprites;

    [SerializeField] private Transform m_camera;

    // Start is called before the first frame update
    private void Awake () {
        Debug.Log("Example1.Awake() was called for ID: " + this.GetInstanceID());
        Party playerParty = ScriptableObject.CreateInstance("Party") as Party;
        Party enemyParty = ScriptableObject.CreateInstance("Party") as Party;
        foreach (var sprite in m_pSprites)  {
            GameObject character = Instantiate(sprite, new Vector3(0, 0), Quaternion.identity, this.GetComponent<Transform>()) as GameObject;
            //p.AddPartyMember(c);
        }
        /*
        foreach (var sprite in m_eSprites)  {
            Character character = gameObject.AddComponent<Character>() as Character;
            character.SetSprite(sprite);
            enemyParty.AddPartyMember(character);
        }
        */
        CombatHandler combatHandler = gameObject.AddComponent<CombatHandler>() as CombatHandler; 
        combatHandler.Setup(playerParty, enemyParty);

        InitCamera();
    }

    private void InitCamera () {
        Instantiate (m_camera, new Vector3(0, 0, -1), Quaternion.identity, this.GetComponent<Transform>());
    }
}
