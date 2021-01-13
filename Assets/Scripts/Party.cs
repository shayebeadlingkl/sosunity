using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Party : ScriptableObject
{
    
    private Party m_instance;
    private List<Character> m_party = new List<Character>();

    private void Awake () {
        m_instance = this;
    }

    private void Start() {
         
    }

    public Party GetInstance() {
        return m_instance;
    }

    public List<Character> GetParty () {
        return this.m_party;
    }

    public void AddPartyMember (Character c) {
        this.m_party.Add(c);
    }

    public void RemovePartyMember (Character c) {
        this.m_party.Remove(c);
    }


}
