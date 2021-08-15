using UnityEngine;

public abstract class Player : MonoBehaviour
{
	protected HealthSystem _healthSystem;

	protected virtual void Initialize()
	{
		
	}
	
	private void Start()
	{
		Initialize();
	}
}
