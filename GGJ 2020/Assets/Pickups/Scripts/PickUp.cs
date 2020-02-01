using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
	public PickUpEffect Effect;

	private void OnTriggerEnter(Collider other)
	{
		Effect.ApplyEffect(other.gameObject);
		Destroy(gameObject);
	}
}

public class PickUpEffect:ScriptableObject
{
	public float Value;
	public virtual void ApplyEffect( GameObject Target)//may need change
	{
		Debug.Log($"Applying {name} to {Target.name}");
	}
}

[CreateAssetMenu(fileName ="Mud Ammo Pick Up",menuName ="Pickups/Mud Ammo")]
public class AmmoPickup : PickUpEffect
{
	public override void ApplyEffect(GameObject Target)
	{
		base.ApplyEffect(Target);
		//increment Ammo of <Target> With <Value>;
	}
}

[CreateAssetMenu(fileName = "Speed Pick Up", menuName = "Pickups/Speed")]
public class MudAmmoPickup : PickUpEffect
{
	public override void ApplyEffect(GameObject Target)
	{
		base.ApplyEffect(Target);
		//increment MudAmmo of <Target> With <Value>;
	}
}

[CreateAssetMenu(fileName = "Ammo Pick Up", menuName = "Pickups/Ammo")]
public class SpeedPickup : PickUpEffect
{
	public override void ApplyEffect(GameObject Target)
	{
		base.ApplyEffect(Target);
		//increment Speed of <Target> With <Value>;
	}
}
