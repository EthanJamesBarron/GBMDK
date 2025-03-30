using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GB.Networking.Objects;
using GB.Networking.Utils.Spawn;
using UnityEngine;

namespace GB.Game
{
	public class GameMode_Football : GameMode
	{
		[CompilerGenerated]
		private sealed class _003CRestartPlay_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public bool playdelay;

			public GameMode_Football _003C_003E4__this;

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
			public _003CRestartPlay_003Ed__28(int _003C_003E1__state)
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
		private sealed class _003CKickOffCountdown_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameMode_Football _003C_003E4__this;

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
			public _003CKickOffCountdown_003Ed__29(int _003C_003E1__state)
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
		private sealed class _003COverTimeCountdown_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameMode_Football _003C_003E4__this;

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
			public _003COverTimeCountdown_003Ed__30(int _003C_003E1__state)
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

		public const string ID = "football";

		private const float RESPAWN_TIMER_BALL = 3f;

		private const float RESPAWN_TIMER_DEAD_PLAYER = 2f;

		private const float RESTART_OF_PLAY_DELAY = 3f;

		private WaitForSeconds playdelayWFS;

		private const string footballPrefabPath = "Football/Football";

		private Football football;

		private FootballGoal[] goals;

		private FootballPopper[] poppers;

		private GBSpawnPoint footballSpawnPoint;

		private bool _canScoreGoals;

		private bool _ballInPlay;

		private bool isOvertime;

		public bool BallInPlay
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override string GetID()
		{
			return null;
		}

		public override bool UseGameTimer()
		{
			return false;
		}

		protected override void InitBeast(NetBeast pBeast)
		{
		}

		public override void SetupGangIDsForOnlineSession(int totalPlayers, bool privateGame)
		{
		}

		public override void Cleanup()
		{
		}

		public override void InitRound()
		{
		}

		public override IEnumerator PreGameCountdown()
		{
			return null;
		}

		public override void StartRound()
		{
		}

		public override bool IsGameValid()
		{
			return false;
		}

		public override void EndRound()
		{
		}

		public void OnGoalScored(int concedingGangID, Football ball)
		{
		}

		[IteratorStateMachine(typeof(_003CRestartPlay_003Ed__28))]
		private IEnumerator RestartPlay(Football ball, bool playdelay)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CKickOffCountdown_003Ed__29))]
		public IEnumerator KickOffCountdown()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003COverTimeCountdown_003Ed__30))]
		public IEnumerator OverTimeCountdown()
		{
			return null;
		}

		public override void GameModeUpdate()
		{
		}

		public override bool IsRoundOver()
		{
			return false;
		}

		public override bool IsTimerExpired()
		{
			return false;
		}

		public override List<NetGang> GetRoundWinners()
		{
			return null;
		}

		public override List<NetGang> GetGameWinners()
		{
			return null;
		}

		public override void SendRoundOverMessage(bool mapComplete)
		{
		}

		public override bool IsGameOver()
		{
			return false;
		}

		public override void HandleScore()
		{
		}

		protected override bool GameWinnerFilter(NetGang beast)
		{
			return false;
		}

		public void OnPopperTriggered(Football ball)
		{
		}
	}
}
