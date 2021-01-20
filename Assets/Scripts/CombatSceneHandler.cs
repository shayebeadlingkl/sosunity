using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatSceneHandler : MonoBehaviour
{
    [SerializeField] private List<GameObject> m_pCharacters;
    [SerializeField] private List<GameObject> m_eCharacters;

    [SerializeField] private Transform m_camera;

    // Start is called before the first frame update
    private void Awake () {
        Debug.Log("Example1.Awake() was called for ID: " + this.GetInstanceID());
        Party playerParty = ScriptableObject.CreateInstance("Party") as Party;
        Party enemyParty = ScriptableObject.CreateInstance("Party") as Party;

        // Coords to place sprites in each party
        int xCoord = 10;
        int yCoord = 0;

        foreach (var character in m_pCharacters)  {
            // Instantiate the character and give it the character component
            GameObject characterObj = Instantiate(character, new Vector3(xCoord, yCoord), Quaternion.identity, this.GetComponent<Transform>()) as GameObject;
            characterObj.AddComponent<Character>();
            playerParty.AddPartyMember(characterObj);
            yCoord += 10;
        }

        xCoord = -10;
        yCoord = 0;
        foreach (var character in m_eCharacters)  {
            GameObject characterObj = Instantiate(character, new Vector3(xCoord, yCoord), Quaternion.identity, this.GetComponent<Transform>()) as GameObject;
            characterObj.AddComponent<Character>();
            enemyParty.AddPartyMember(characterObj);
            yCoord += 10;
        }

        CombatHandler combatHandler = gameObject.AddComponent<CombatHandler>() as CombatHandler;
        combatHandler.Setup(playerParty, enemyParty);

        InitCamera();
    }

    private void InitCamera () {
        Instantiate (m_camera, new Vector3(0, 0, -1), Quaternion.identity, this.GetComponent<Transform>());
    }
}
