using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Party : ScriptableObject
{
    
    private Party m_instance;
    private List<GameObject> m_party = new List<GameObject>();

    private void Awake () {
        m_instance = this;
    }

    private void Start() {
         
    }

    public Party GetInstance() {
        return m_instance;
    }

    public List<GameObject> GetParty () {
        return this.m_party;
    }

    public void AddPartyMember (GameObject character) {
        this.m_party.Add(character);
    }

    public void RemovePartyMember (GameObject character) {
        this.m_party.Remove(character);
    }


}
