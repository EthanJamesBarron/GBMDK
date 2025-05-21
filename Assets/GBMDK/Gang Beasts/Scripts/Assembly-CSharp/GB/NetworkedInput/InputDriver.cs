using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Femur;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GB.NetworkedInput
{
	public class InputDriver : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDelayPauseRescan_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public InputDriver _003C_003E4__this;

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
			public _003CDelayPauseRescan_003Ed__11(int _003C_003E1__state)
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

		public bool OverrideControl;

		public InputState DrivenState;

		private Actor _Actor;

		private int m_Frame;

		private int m_ControllerId;

		private bool _lastSetDoubleJump;

		private float unPauseTime;

		public void Initialise(Actor controllingActor)
		{
		}

		public void DisconnectController()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnPauseAltered()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayPauseRescan_003Ed__11))]
		private IEnumerator DelayPauseRescan()
		{
			return null;
		}

		private void InputActionTriggered(InputAction.CallbackContext context)
		{
		}

		private void Update()
		{
		}

		public void ResetInput()
		{
		}

		public void RescanInput()
		{
		}

		private void PauseScanInput()
		{
		}

		private void OnApplicationFocus(bool focusState)
		{
		}

		private Vector3 GetForward()
		{
			return default(Vector3);
		}

		public void SetVibration(float lowFrequency, float highFrequency, float duration)
		{
		}

		public void StopVibration()
		{
		}

		private bool IsVibrationAllowed()
		{
			return false;
		}
	}
}
