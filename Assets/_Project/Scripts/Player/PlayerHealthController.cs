using UnityEngine;

public sealed class PlayerHealthController : Player, IDamageable
{
	[Header("Health System")]
	[SerializeField] private int _maxHealth;
	
	public void TakeDamage(int damageAmount)
	{
		_healthSystem.Damage(damageAmount);
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

	private void Update()
	{
		Debug.Log(_healthSystem.GetCurrentHealthAmount());
	}
}
