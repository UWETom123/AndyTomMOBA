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

    public Texture2D m_heroSprite;

    public float m_movementSpeed;
    public float m_jumpStrength;

    public Ability[] m_heroAbilities;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
