using UnityEngine;

namespace RPG.AI.Enemies
{
	[CreateAssetMenu(menuName = "Enemy/Enemy Data")]
	public sealed class EnemyData : ScriptableObject
	{
		[Header("Health System")]
		public int MaxHealth;

		[Header("Attack")]
		public int AttackForce;
		public int CriticalChance;
	
		[Header("Defense")]
		public int Armor;
	}
}
