using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CoreNet.Components.Server;
using CoreNet.Objects;
using Femur;
using GB.Config;
using GB.Gamemodes;
using GB.Networking;
using GB.Networking.Components.Server;
using GB.Networking.Delegates;
using GB.Networking.Objects;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

namespace GB.Game
{
	public class GameManagerNew : NetServerGameManager
	{
		public enum GameType
		{
			Local = 0,
			LocalServer = 1,
			PHosted = 2,
			Matchmaker = 3
		}

		[Flags]
		public enum GameState
		{
			Inactive = 0,
			ServerChangingScene = 1,
			WaitingForClientsToLoad = 2,
			GameSetup = 4,
			PreStartCountdown = 8,
			Active = 0x10,
			PostGame = 0x20,
			DisplayingScores = 0x40,
			GameEnded = 0x80
		}

		public class VolatileSPData
		{
			public bool initialised;

			public int numSpawnedInSet1;

			public int numSpawnedInSet2;

			public void Reset()
			{
			}
		}

		public delegate void RotationConfigChanged(RotationConfig rotationConfig);

		private class Timer
		{
			public bool Active;

			private float _timer;

			public bool Done => false;

			public void Start(float value)
			{
			}

			public bool Update()
			{
				return false;
			}
		}

		public class LocalWirelessConfig
		{
			public int TotalPlayers { get; set; }

			public bool PrivateGame => false;
		}

		[CompilerGenerated]
		private sealed class _003CEndRoundOrGame_003Ed__88 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameManagerNew _003C_003E4__this;

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
			public _003CEndRoundOrGame_003Ed__88(int _003C_003E1__state)
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
		private sealed class _003CCloseLocalServer_003Ed__91 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameManagerNew _003C_003E4__this;

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
			public _003CCloseLocalServer_003Ed__91(int _003C_003E1__state)
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
		private sealed class _003CCloseGame_003Ed__92 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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
			public _003CCloseGame_003Ed__92(int _003C_003E1__state)
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
		private sealed class _003CSpawnRoutine_003Ed__98 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameManagerNew _003C_003E4__this;

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
			public _003CSpawnRoutine_003Ed__98(int _003C_003E1__state)
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
		private sealed class _003CPreStartCountdown_003Ed__100 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameManagerNew _003C_003E4__this;

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
			public _003CPreStartCountdown_003Ed__100(int _003C_003E1__state)
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

		private static GameManagerNew instance;

		private GameState internalCurrentState;

		private VolatileSPData volSPData;

		private GameConfig activeConfigIndex;

		private int _nextConfigIndex;

		private int tempMinRequiredPlayers;

		private bool authPassed;

		private bool gameManagerSetup;

		private bool allPlayersLoaded;

		private Timer joinTimer;

		private const float kJoinTimeout = 60f;

		private const float kWirelessJoinTimeout = 120f;

		private const float kJoinAfterKickTimeout = 10f;

		private GameType internalGameType;

		private GameModeSetupConfiguration tracker;

		private LocalWirelessConfig localWirelessData;

		private WaitForSeconds halfSecondWFS;

		private WaitForSeconds singleSecondWFS;

		private WaitForSeconds winnerZoomWFS;

		private WaitForSeconds endOfRoundWFS;

		private WaitForSeconds winnerCelebrationWFS;

		private WaitForSeconds loadscreenWFS;

		private Coroutine _spawnCoroutine;

		private Coroutine _endGameCoroutine;

		private GBMultiplayServerCommunicator serverCommunicator;

		private RotationConfig internalRotationConfig;

		private GameMode internalActiveGameMode;

		private bool hasTriggeredFirstKick;

		private Vector3 confettiOffset;

		public static GameManagerNew Instance => null;

		public GameState CurrentState
		{
			get
			{
				return default(GameState);
			}
			private set
			{
			}
		}

		protected int NextConfigIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public GameType CurrentGameType
		{
			get
			{
				return default(GameType);
			}
			private set
			{
			}
		}

		public RotationConfig RotationConfig
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public GameConfig CurrentGameConfig => null;

		public GameMode ActiveGameMode
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public static event Handler OnGameManagerCreated
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

		public static event Handler OnRoundStart
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

		public static event Handler OnRoundEnd
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

		public static event RotationConfigChanged OnRotationConfigChanged
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

		public static event Action<GameModeEnum> OnGameModeChanged
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

		public static void FlushEvents()
		{
		}

		private new void Awake()
		{
		}

		private void Start()
		{
		}

		private new void OnDestroy()
		{
		}

		private void OnGbSessionDataReceived(GBSessionData sessionData)
		{
		}

		public void SetGameType(GameType gameType)
		{
		}

		public void SetWirelessData(LocalWirelessConfig data)
		{
		}

		public void ChangeRotationConfig(RotationConfig config, int startLevelIndex = 0)
		{
		}

		public void ChangeRotationConfig(RotationConfig config, string startingLevel)
		{
		}

		public void PrepLoadingForNextLevel(int index)
		{
		}

		public void StartGame()
		{
		}

		private void SetupGameMode(GameModeEnum gameModeType)
		{
		}

		private IEnumerator InitGameModeAndPreStart()
		{
			return null;
		}

		private void StartRound()
		{
		}

		public void OnRestart()
		{
		}

		private void OnActorStateChanged(Actor actor, int connectionId, Actor.ActorState state)
		{
		}

		private void Update()
		{
		}

		private void ForceStartCheck()
		{
		}

		private void StartPostGame()
		{
		}

		[IteratorStateMachine(typeof(_003CEndRoundOrGame_003Ed__88))]
		private IEnumerator EndRoundOrGame()
		{
			return null;
		}

		private void EndGameSession(string disconnectMessage)
		{
		}

		private void Shutdown(string disconnectMessage)
		{
		}

		[IteratorStateMachine(typeof(_003CCloseLocalServer_003Ed__91))]
		private IEnumerator CloseLocalServer()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCloseGame_003Ed__92))]
		private IEnumerator CloseGame()
		{
			return null;
		}

		private bool GetRotationComplete()
		{
			return false;
		}

		public bool CheckComplete()
		{
			return false;
		}

		public override void Cycle()
		{
		}

		protected override void OnAllClientsLoaded()
		{
		}

		protected void OnClientSceneLoaded(NetworkConnection conn, NetMember member)
		{
		}

		[IteratorStateMachine(typeof(_003CSpawnRoutine_003Ed__98))]
		private IEnumerator SpawnRoutine()
		{
			return null;
		}

		private bool CheckAndStartGame(bool bypassMMPlayerCheck, bool kickSlowLoaders)
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CPreStartCountdown_003Ed__100))]
		private IEnumerator PreStartCountdown()
		{
			return null;
		}

		private void ChangeSceneInternal(string sceneName)
		{
		}

		private void OnActiveSceneChanged(Scene prevScene, Scene newScene)
		{
		}

		private bool MatchmakingPlayersConnected()
		{
			return false;
		}

		private void SpawnWinnerConfetti()
		{
		}

		private void OnNetDataStartCheck(NetConnectionAssociation item)
		{
		}

		private void OnNetDataBlank(NetConnectionAssociation item)
		{
		}

		private void OnNetBeastRemoved(NetBeast beast)
		{
		}
	}
}
