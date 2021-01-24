using UnityEngine;
public class JSONReader : MonoBehaviour
{
    public TextAsset jsonFile;
    void Start()
    {
        Party partyInJson = JsonUtility.FromJson<Party>(jsonFile.text);
        // foreach (GameObject character in partyInJson.GetParty())
        // {
        //     Debug.Log("Found character: " + character.characterName);
        // }
    }
}