using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Work in progress base class for abilities
//All abilities will inherit from this class
//Added by Tom Moreton 18/05/2017

public class Ability : MonoBehaviour {

    public enum m_AbilityType
    {
        Active, Passive, Toggle
    }
    public m_AbilityType m_myAbilityType;

    public Texture2D m_AbilityIcon;

    public float m_Damage;
    public float m_Radius;
    public float m_Range;
    public float m_Cooldown;

    public string m_keybind;
    
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
