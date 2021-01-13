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
        Party p = ScriptableObject.CreateInstance("Party") as Party;
        Party e = ScriptableObject.CreateInstance("Party") as Party;
        foreach (var s in m_pSprites)  {
            GameObject c = Instantiate(s, new Vector3(0, 0), Quaternion.identity, this.GetComponent<Transform>()) as GameObject;
            //p.AddPartyMember(c);
        }
        /*
        foreach (var s in m_eSprites)  {
            Character c = gameObject.AddComponent<Character>() as Character;
            c.SetSprite(s);
            e.AddPartyMember(c);
        }
        */
        CombatHandler ch = gameObject.AddComponent<CombatHandler>() as CombatHandler; 
        ch.Setup(p, e);

        InitCamera();
    }

    private void InitCamera () {
        Instantiate (m_camera, new Vector3(0, 0, -1), Quaternion.identity, this.GetComponent<Transform>());
    }
}
