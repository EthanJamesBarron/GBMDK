using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CoreNet.Utils;
using Femur;
using GB.Networking.Objects;
using UnityEngine;

public static class GameModeUtils
{
	public class RespawnManager
	{
		private struct RespawnElement
		{
			public NetBeast beast;

			public Coroutine coroutine;

			public RespawnElement(NetBeast beast, Coroutine coroutine)
			{
				this.beast = null;
				this.coroutine = null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CRespawnTimer_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float respawnTimer;

			public RespawnManager _003C_003E4__this;

			public NetBeast beast;

			public Func<NetBeast, SpawnParams> spawnTypeNeeds;

			public Action<NetBeast, Actor> OnBeastSpawned;

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
			public _003CRespawnTimer_003Ed__10(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CRespawnPlayer_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NetBeast beast;

			public Func<NetBeast, SpawnParams> spawnTypeNeeds;

			public Action<NetBeast, Actor> OnBeastSpawned;

			public RespawnManager _003C_003E4__this;

			private SpawnParams _003Cparameters_003E5__2;

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
			public _003CRespawnPlayer_003Ed__11(int _003C_003E1__state)
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

		private List<RespawnElement> _respawnList;

		private List<CoreNetSpawnPosition> _usedSpawns;

		public List<CoreNetSpawnPosition> UsedSpawns => null;

		public void ClearSpawnQueue()
		{
		}

		public void FreeSpawnPoints()
		{
		}

		public bool HasQueued(int gangID)
		{
			return false;
		}

		public int HasTotalQueued(int gangID)
		{
			return 0;
		}

		public void QueueRespawn(float respawnTimer, NetBeast beast, Func<NetBeast, SpawnParams> spawnTypeNeeds, Action<NetBeast, Actor> OnBeastSpawned)
		{
		}

		[IteratorStateMachine(typeof(_003CRespawnTimer_003Ed__10))]
		private IEnumerator RespawnTimer(float respawnTimer, NetBeast beast, Func<NetBeast, SpawnParams> spawnTypeNeeds, Action<NetBeast, Actor> OnBeastSpawned)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CRespawnPlayer_003Ed__11))]
		private IEnumerator RespawnPlayer(NetBeast beast, Func<NetBeast, SpawnParams> spawnTypeNeeds, Action<NetBeast, Actor> OnBeastSpawned)
		{
			return null;
		}
	}

	public static List<NetGang> HighestMapScore()
	{
		return null;
	}

	public static void SendMessage(string message, Vector2 offset, Color color)
	{
	}
}
