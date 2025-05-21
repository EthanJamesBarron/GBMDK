using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GB.UI.Utils
{
	public class ControllerDisconnectUI : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003COnDismissDisconnectWarningCoroutine_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ControllerDisconnectUI _003C_003E4__this;

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
			public _003COnDismissDisconnectWarningCoroutine_003Ed__14(int _003C_003E1__state)
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

		private string CONTROLLER_DISCONNECT_KEY;

		private int _lostController;

		private bool _isShowingDisconnect;

		private List<int> _userCache;

		private List<int> _freeInputs;

		public bool IsShowing => false;

		public void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnControllerDisconnected(in InputDevice device, int userIndex)
		{
		}

		private bool ShowDisconnectMessage()
		{
			return false;
		}

		private void ControllerSetupSwitcher()
		{
		}

		private void OnControllerConnected(in InputDevice device, int userIndex)
		{
		}

		private void OnDismissDisconnectWarning()
		{
		}

		[IteratorStateMachine(typeof(_003COnDismissDisconnectWarningCoroutine_003Ed__14))]
		private IEnumerator OnDismissDisconnectWarningCoroutine()
		{
			return null;
		}

		private void CleanLostPlayers()
		{
		}

		private void ReassignControllerLost()
		{
		}

		private void RegisterInputEvents()
		{
		}
	}
}
