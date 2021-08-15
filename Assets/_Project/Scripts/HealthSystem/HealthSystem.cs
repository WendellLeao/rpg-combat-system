public sealed class HealthSystem
{
	private int _maxHealthAmount, _currentHealthAmount;

	public HealthSystem(int maxHealthAmount)
	{
		_maxHealthAmount = maxHealthAmount;

		_currentHealthAmount = maxHealthAmount;
	}

	public void Damage(int damageAmount)
	{
		_currentHealthAmount -= damageAmount;

		if (_currentHealthAmount <= 0)
		{
			_currentHealthAmount = 0;
		}
	}

	public void AddHealth(int healthAmount)
	{
		_currentHealthAmount += healthAmount;

		if (_currentHealthAmount >= _maxHealthAmount)
		{
			_currentHealthAmount = _maxHealthAmount;
		}
	}

	public void ResetCurrentHealthAmount()
	{
		_currentHealthAmount = _maxHealthAmount;
	}

	public int GetCurrentHealthAmount()
	{
		return _currentHealthAmount;
	}

	public int GetMaxHealthAmount()
	{
		return _maxHealthAmount;
	}
}
