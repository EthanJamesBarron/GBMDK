using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CoreNet.Model;
using CoreNet.Utils;
using Costumes;
using Femur;
using GB.Config;
using GB.Gamemodes;
using GB.Networking.Components.Server;
using GB.Networking.Objects;
using UnityEngine;

namespace GB.Game
{
	public abstract class GameMode
	{
		public enum SpawnMode
		{
			Random = 0,
			ByGang = 1
		}

		public enum SpawnPriority
		{
			SpawnSet = 0,
			GangID = 1
		}

		[CompilerGenerated]
		private sealed class _003CStartupSpawnPlayers_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameMode _003C_003E4__this;

			public List<NetBeast> players;

			private List<CoreNetSpawnPosition> _003CusedSpawns_003E5__2;

			private int _003Ci_003E5__3;

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
			public _003CStartupSpawnPlayers_003Ed__33(int _003C_003E1__state)
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
		private sealed class _003CPreGameCountdown_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameMode _003C_003E4__this;

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
			public _003CPreGameCountdown_003Ed__48(int _003C_003E1__state)
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

		protected static List<int> activeGangIds;

		protected GameConfig _Config;

		protected NetModel _Model;

		protected int _NextGangId;

		protected float timer;

		protected int timerTrigger;

		protected int lastSentTime;

		protected bool alwaysShowTimer;

		protected bool isInitialised;

		public bool localSingleGang;

		protected ColorDatabase colorDatabase;

		protected WaitForSeconds singleSecondWFS;

		private GBServerSpawnManager _spawnManager;

		protected GameModeEnum _modeType;

		public GBServerSpawnManager SpawnManager => null;

		public bool IsInitialised => false;

		public virtual bool ReloadBetweenRounds => false;

		public GameModeEnum ModeType => default(GameModeEnum);

		public virtual SpawnMode SpawnMethod => default(SpawnMode);

		public virtual SpawnPriority SpawnPointPriority => default(SpawnPriority);

		public static event Action<NetBeast, Actor> OnBeastSpawned
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		public abstract string GetID();

		[IteratorStateMachine(typeof(_003CStartupSpawnPlayers_003Ed__33))]
		public virtual IEnumerator StartupSpawnPlayers(List<NetBeast> players)
		{
			return null;
		}

		public virtual SpawnParams SetupGameModeSpawnParams(NetBeast netBeast)
		{
			return null;
		}

		public virtual bool UseGameTimer()
		{
			return false;
		}

		public virtual void SendRoundBeginMessage()
		{
		}

		public virtual void SendRoundOverMessage(bool mapComplete)
		{
		}

		public void Setup(NetModel model, GameConfig config)
		{
		}

		public virtual void Init()
		{
		}

		public virtual void ApplyPublicRotationModifiers(ref RotationConfig config)
		{
		}

		public virtual void SetupGangIDsForOnlineSession(int totalPlayers, bool privateGame)
		{
		}

		public virtual void SetupNewBeast(NetBeast beast)
		{
		}

		protected virtual void InitBeast(NetBeast pBeast)
		{
		}

		public virtual void JIPInitBeast(NetBeast pBeast)
		{
		}

		protected virtual void InitGang(int gangId)
		{
		}

		public virtual void Cleanup()
		{
		}

		public virtual void InitRound()
		{
		}

		[IteratorStateMachine(typeof(_003CPreGameCountdown_003Ed__48))]
		public virtual IEnumerator PreGameCountdown()
		{
			return null;
		}

		public virtual void StartRound()
		{
		}

		public abstract void EndRound();

		public abstract bool IsRoundOver();

		public abstract bool IsGameValid();

		public virtual void SetupTimer(float gameTimeAllowed, int lowTimerTrigger = 30)
		{
		}

		public virtual void GameModeUpdate()
		{
		}

		public virtual bool IsTimerExpired()
		{
			return false;
		}

		public virtual void HandleScore()
		{
		}

		public virtual void OnBeastDeath(NetBeast beast, Actor actor)
		{
		}

		public virtual bool IsGameOver()
		{
			return false;
		}

		public abstract List<NetGang> GetRoundWinners();

		public virtual List<NetGang> GetGameWinners()
		{
			return null;
		}

		protected abstract bool GameWinnerFilter(NetGang beast);

		protected static int[] RemainingGangsAlive()
		{
			return null;
		}

		protected static int GetNumRemainingGangsAlive()
		{
			return 0;
		}

		protected void OneTeamPrevention(int teams)
		{
		}

		protected void SetBalancedTeams(int totalTeams)
		{
		}

		public virtual void BeastSpawned(NetBeast beast, Actor actor)
		{
		}
	}
}
