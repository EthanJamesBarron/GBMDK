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
	public class LobbyConnections : LobbyPart
	{
		private class PingCarrier
		{
			[CompilerGenerated]
			private sealed class _003CPingLoop_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public PingCarrier _003C_003E4__this;

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
				public _003CPingLoop_003Ed__13(int _003C_003E1__state)
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

			public BaseUserInfo user;

			private Ping pinger;

			private int _lastTime;

			private string _ip;

			public Coroutine looper;

			public int Time
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public string IP
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool PingActive => false;

			[IteratorStateMachine(typeof(_003CPingLoop_003Ed__13))]
			public IEnumerator PingLoop()
			{
				return null;
			}
		}

		public static Action<BaseUserInfo, int> OnPingUpdate;

		private Dictionary<BaseUserInfo, PingCarrier> _pings;

		private StringMessage _ipMessage;

		private bool _drawInspector;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public override void ClearData()
		{
		}

		public void SendIp()
		{
		}

		private void SendIp(BaseUserInfo arg1, StringMessage arg2)
		{
		}

		private void GotIp(BaseUserInfo arg1, StringMessage arg2)
		{
		}

		private void FindMyIP()
		{
		}

		private void OnPlayerLeft(BaseUserInfo user)
		{
		}

		public int GetPing(BaseUserInfo user)
		{
			return 0;
		}

		public override void DrawInspector()
		{
		}
	}
}
