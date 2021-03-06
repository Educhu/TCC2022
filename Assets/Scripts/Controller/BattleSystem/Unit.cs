using Assets.Scripts.Controller.Enums;
using Assets.Scripts.Extensions;
using UnityEngine;

[System.Serializable]
public class Unit : MonoBehaviour
{
	public string unitName;
	public int unitLevel;

	public float damage;

	public float maxHP;
	public float currentHP;

	public Element? unitElement = null;

	void start()
    {
		
	}
   
    public bool ElementalTakeDamage(Element element)
	{
		damage = ElementExtensions.GetElementalDamage(element, unitElement) / 20;

		if (currentHP == damage || currentHP < damage)
        {
			currentHP = 0;
			return true;
		}
		else
        {
			currentHP -= damage;
			return false;
		}
	}

	public void Heal(float amount)
	{
		currentHP += amount;
		if (currentHP > maxHP)
			currentHP = maxHP;
	}
}
