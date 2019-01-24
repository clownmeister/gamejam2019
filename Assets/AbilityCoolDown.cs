using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AbilityCoolDown : MonoBehaviour {

	public string abilityButtonAxisName = "Fire1";
	public Image darkMask;
	public Text coolDownTextDisplay;

	[SerializeField] private Ability ability;
	[SerializeField] private GameObject weaponHolder;
	private Image myButtonImage;
	private AudioSource abilitySource;
	private float coolDownDuration;
	private float nextReadyTime;
	private float coolDownTimeLeft;


	void Start () 
	{
		Initialize (ability, weaponHolder); 
	}

	public void Initialize(Ability selectedAbility, GameObject weaponHolder)
	{
		ability = selectedAbility;
		myButtonImage = GetComponent<Image> ();
		abilitySource = GetComponent<AudioSource> ();
		myButtonImage.sprite = ability.aSprite;
		darkMask.sprite = ability.aSprite;
		coolDownDuration = ability.aBaseCoolDown;
		ability.Initialize (weaponHolder);
		AbilityReady ();
	}

	// Update is called once per frame
	void Update () 
	{
		bool coolDownComplete = (Time.time > nextReadyTime);
		if (coolDownComplete) 
		{
			AbilityReady ();
