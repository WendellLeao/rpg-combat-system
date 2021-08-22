using RPG.Systems.Health;
using UnityEngine;

namespace RPG.Player
{
	public sealed class PlayerHealthController : Player, IDamageable
	{
		[Header("Health System")]
		[SerializeField] private int _maxHealth;

		private HealthSystem _healthSystem;
	
		public void TakeDamage(int damageAmount)
		{
			_healthSystem.Damage(damageAmount);
		
			RaiseOnPlayerGetHittedEvent();
		}

		protected override void Initialize()
		{
			base.Initialize();
		
			InitializeHealthSystem();
		}

		private void InitializeHealthSystem()
		{
			_healthSystem = new HealthSystem(_maxHealth);
		}

		private void RaiseOnPlayerGetHittedEvent()
		{
			int maxHealthAmount = _healthSystem.GetMaxHealthAmount();
			int currentHealthAmount = _healthSystem.GetCurrentHealthAmount();
		
			_localGameEvents.OnPlayerGetHitted?.Invoke(currentHealthAmount, maxHealthAmount);
		}
	}
}
