using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CoreNet.Messaging;
using CoreNet.Messaging.Messages;
using CoreNet.Objects;
using GB.Networking.Components.Server;
using UnityEngine;
using UnityEngine.Networking;

namespace CoreNet.Components.Server
{
	[RequireComponent(typeof(NetServerExit))]
	public abstract class NetServerMemberManager : NetComponent
	{
		public struct AuthenticationResult
		{
			public bool Success;

			public string Error;
		}

		[CompilerGenerated]
		private sealed class _003CPasswordTimeout_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NetConnection connection;

			public NetServerMemberManager _003C_003E4__this;

			private float _003Ctimer_003E5__2;

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
			public _003CPasswordTimeout_003Ed__24(int _003C_003E1__state)
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

		private int _maxAllowedPlayers;

		protected NetServerExit ServerExit;

		protected GBMultiplayServerCommunicator ServerCommunicator;

		private Dictionary<int, int> reservePlayerSlots;

		public int MaxAllowedPlayers
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected virtual void OnMaxPlayersUpdated(int newMaxPlayers)
		{
		}

		protected new void Awake()
		{
		}

		private void OnMemberSetupHandler(NetBoolMessage message, NetworkConnection conn)
		{
		}

		protected virtual void OnDestroy()
		{
		}

		private void OnClientConnectionAdded(NetConnection connection)
		{
		}

		private void OnClientConnectionUpdated(NetConnection connection)
		{
		}

		private void OnClientConnectionRemoved(NetConnection connection)
		{
		}

		private void OnMemberAdded(NetMember member)
		{
		}

		private void OnMemberUpdated(NetMember member)
		{
		}

		private void OnMemberRemoved(NetMember member)
		{
		}

		protected void RegisterPlayersHandler<T>() where T : NetPlayer, new()
		{
		}

		protected void RemovePlayersFromMember<T>(NetMember member) where T : NetPlayer, new()
		{
		}

		protected abstract void RegisterCustomPlayersHandler();

		protected abstract void RemoveCustomPlayersFromMember(NetMember member);

		private void AdmitConnection(NetworkConnection conn, NetAuthMessage message)
		{
		}

		private void AuthenticateConnection(NetConnection connection)
		{
		}

		[IteratorStateMachine(typeof(_003CPasswordTimeout_003Ed__24))]
		private IEnumerator PasswordTimeout(NetConnection connection)
		{
			return null;
		}

		private NetMessenger.MessageCallback<NetPlayersMessage<T>> GetReceivePlayersHandler<T>() where T : NetPlayer, new()
		{
			return null;
		}

		private void RemoveMemberForConnection(NetConnection connection)
		{
		}

		private NetMessenger.MessageCallback<NetAuthMessage> GenerateCredentialHandler()
		{
			return null;
		}

		protected virtual AuthenticationResult Authenticate(NetworkConnection conn, NetAuthMessage message)
		{
			return default(AuthenticationResult);
		}

		protected virtual void FinaliseConnection(NetworkConnection conn, NetAuthMessage message, AuthenticationResult result)
		{
		}
	}
}
