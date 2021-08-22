using RPG.Systems.Health;
using UnityEngine;
using RPG.Player;

namespace RPG.AI.Enemies
{
	public abstract class Enemy : MonoBehaviour, IDamageable
	{
		[Header("Enemy Data")]
		[SerializeField] protected EnemyData _enemyData;

		[Header("Health System")]
		protected HealthSystem _healthSystem;
		
		public void TakeDamage(int damageAmount)
		{
			_healthSystem.Damage(damageAmount);
		}

		protected virtual void OnTriggerEnter(Collider other)
		{
			if (other.TryGetComponent(out PlayerHealthController playerHealthController))
			{
				playerHealthController.TakeDamage(_enemyData.AttackForce);
			}
		}
	}
}
