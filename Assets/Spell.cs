using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Spell", menuName = "Spell/Basic", order = 1)]

public class Spell : MonoBehaviour{

	public float manaCost;

	virtual public void Cast(Actor[] target, Actor castor){

		//spell cast code goes here
	}

}