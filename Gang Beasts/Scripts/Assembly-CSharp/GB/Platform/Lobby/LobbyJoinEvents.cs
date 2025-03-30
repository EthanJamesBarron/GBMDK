using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CS.CorePlatform;
using GB.Platform.Lobby.Messages;
using UnityEngine;

namespace GB.Platform.Lobby
{
	public class LobbyJoinEvents : LobbyPart
	{
		[CompilerGenerated]
		private sealed class _003CStartRequestingSlot_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LobbyJoinEvents _003C_003E4__this;

			private int _003Cmain_003E5__2;

			private BasePlatformManager _003Cplatform_003E5__3;

			private int _003Cretries_003E5__4;

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
			public _003CStartRequestingSlot_003Ed__8(int _003C_003E1__state)
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

		private int _joinWaitAmount;

		private int _joinRetryAmount;

		private Coroutine _retryer;

		private BasePlatformManager _platformCache;

		private LobbyMessage _requestMessage;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void PlatformEvents_OnLobbyJoinedEvent()
		{
		}

		[IteratorStateMachine(typeof(_003CStartRequestingSlot_003Ed__8))]
		private IEnumerator StartRequestingSlot()
		{
			return null;
		}

		private void LobbyPlayerManager_OnPlayerJoined(BaseUserInfo arg1, int arg2)
		{
		}

		public override void ClearData()
		{
		}
	}
}
