using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Work in progress base class for heroes/students
//All heroes will inherit from this class
//Added by Tom Moreton 18/05/2017
public class Hero : MonoBehaviour {

    public string m_heroName;

    public int m_health;
    public int m_damage;

    public enum m_heroStatus
    {
        Slowed,
        Stunned,
        Default,
        DamageAmplified,
        HealthAmplified
    }

    public m_heroStatus m_myHeroStatus;

    public enum m_heroType
    {
        Bully,
        Nerd,
        Jock
    }

    public m_heroType m_myHeroType;

    public Sprite m_heroSprite;

    public float m_movementSpeed;
    public float m_jumpStrength;
    [System.Serializable]
    public struct m_heroStats
    {
        public int m_heroXP;
        public int m_heroGold;
        public int m_heroKills;
        public int m_heroAssits;
        public int m_heroHealing;
        public int m_heroDamage;
    }

    public Ability[] m_heroAbilities;
	// Use this for initialization
	void Start () {
        gameObject.GetComponent<SpriteRenderer>().sprite = m_heroSprite;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
