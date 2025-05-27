using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GB.Platform.UI.Lobby
{
	public class LobbyJumper : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CRunCheckingLook_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LobbyJumper _003C_003E4__this;

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
			public _003CRunCheckingLook_003Ed__9(int _003C_003E1__state)
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

		public GameObject LobbyMenu;

		public GameObject QuickfindMenu;

		public GameObject[] Menus;

		private void Awake()
		{
		}

		private void PlatformEvents_OnEntitlementChangedEvent(bool effect)
		{
		}

		private void OnDestroy()
		{
		}

		private void OnLobbyJoinedEvent()
		{
		}

		private void OnEnable()
		{
		}

		public void CheckLobby()
		{
		}

		[IteratorStateMachine(typeof(_003CRunCheckingLook_003Ed__9))]
		private IEnumerator RunCheckingLook()
		{
			return null;
		}

		public void ManualQuickfindReconnJump()
		{
		}
	}
}
