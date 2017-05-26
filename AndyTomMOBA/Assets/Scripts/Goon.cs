using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Work in progress base class for goons 
//All goons will inherit from this class
//Added by Tom Moreton 24/05/2017
public class Goon : MonoBehaviour {

    public enum m_goonType
    {
        Melee,
        Range,
        Siege
    }

    public m_goonType m_myType;

    public int m_maxHealth;
    public int m_currentHealth;
    public int m_attackDamage;
    public int m_goldBounty;
    public int m_xpBounty;
    
    public float m_movementSpeed;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
