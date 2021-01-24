using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatSceneHandler : MonoBehaviour
{
    [SerializeField] private List<GameObject> pCharacters;
    [SerializeField] private List<GameObject> eCharacters;

    [SerializeField] private int xMargin;
    [SerializeField] private int yMargin;
    [SerializeField] private int yDelta;


    // Start is called before the first frame update
    private void Awake () {
        Debug.Log("Example1.Awake() was called for ID: " + this.GetInstanceID());
        Party playerParty = ScriptableObject.CreateInstance("Party") as Party;
        Party enemyParty = ScriptableObject.CreateInstance("Party") as Party;

        // Coords to place sprites in each party
        GameObject cameraObj = GameObject.Find("Camera");
        Camera camera = cameraObj.GetComponent<Camera>();
        int xCoord = xMargin;
        int yCoord = camera.pixelHeight - yMargin;

        foreach (var character in pCharacters)  {
            // Instantiate the character and give it the character component
            GameObject characterObj = Instantiate(character, new Vector3(xCoord, yCoord), Quaternion.identity, this.GetComponent<Transform>()) as GameObject;
            characterObj.AddComponent<Character>();
            playerParty.AddPartyMember(characterObj);
            yCoord += yDelta;
        }

        xCoord = camera.pixelWidth - xMargin;
        yCoord = camera.pixelHeight - yMargin;
        foreach (var character in eCharacters)  {
            GameObject characterObj = Instantiate(character, new Vector3(xCoord, yCoord), Quaternion.identity, this.GetComponent<Transform>()) as GameObject;
            characterObj.AddComponent<Character>();
            enemyParty.AddPartyMember(characterObj);
            yCoord += yDelta;
        }

        CombatHandler combatHandler = gameObject.AddComponent<CombatHandler>() as CombatHandler;
        combatHandler.Setup(playerParty, enemyParty);

    }

}
