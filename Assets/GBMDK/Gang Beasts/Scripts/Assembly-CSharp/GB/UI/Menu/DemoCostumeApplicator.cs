using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GB.Platform.Lobby;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace GB.UI.Menu
{
	public class DemoCostumeApplicator : MonoBehaviour
	{
		private class ButtonCarrier
		{
			[CompilerGenerated]
			private sealed class _003CPulse_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public float time;

				public ButtonCarrier _003C_003E4__this;

				private float _003Cremaining_003E5__2;

				private ColorBlock _003Ccolours_003E5__3;

				object IEnumerator<object>.Current
				{
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				object IEnumerator.Current
				{
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[DebuggerHidden]
				public _003CPulse_003Ed__9(int _003C_003E1__state)
				{
				}

				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				private bool MoveNext()
				{
					return false;
				}

				bool IEnumerator.MoveNext()
				{
					//ILSpy generated this explicit interface implementation from .override directive in MoveNext
					return this.MoveNext();
				}

				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}
			}

			public GameObject obj;

			public Button button;

			private Coroutine pulse;

			private Color colourTarget;

			public bool IsPulsing => false;

			public ButtonCarrier(GameObject obj, Button button)
			{
			}

			public void StartPulse(MonoBehaviour obj, float time)
			{
			}

			public void ClearPulse(MonoBehaviour obj)
			{
			}

			[IteratorStateMachine(typeof(_003CPulse_003Ed__9))]
			private IEnumerator Pulse(float time)
			{
				return null;
			}

			public void ColourUpdated(Color colour)
			{
			}
		}

		private int[] _enableUserInputs;

		[SerializeField]
		private Transform _buttonHolder;

		[SerializeField]
		private GameObject _buttonBase;

		[SerializeField]
		private Button _buttonElement;

		[SerializeField]
		private TextMeshProUGUI _buttonUI;

		[SerializeField]
		private UnityEvent _startGameOnSpace;

		[SerializeField]
		private string _costumeColourUp;

		[SerializeField]
		private string _costumeColourDown;

		[SerializeField]
		private DemoSetup _setupManager;

		[SerializeField]
		private float _pulseTime;

		[SerializeField]
		private string _pulseKey;

		private List<ButtonCarrier> _buttons;

		private void Awake()
		{
		}

		private void AddPlayer(int playerid)
		{
		}

		private void RemovePlayer(int playerid)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void UpdateButtons()
		{
		}

		private void UpdateButtonColour(LocalPlayerInfomationCache player, int arg2)
		{
		}
	}
}
