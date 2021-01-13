using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private Sprite m_sprite;

    public void SetSprite (Sprite s) {
        this.m_sprite = s;
    }
}
