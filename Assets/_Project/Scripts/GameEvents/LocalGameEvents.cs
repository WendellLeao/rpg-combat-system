using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Game Events/Local Game Events")]
public sealed class LocalGameEvents : ScriptableObject
{
	public UnityAction<int, int> OnPlayerGetHitted;
}
