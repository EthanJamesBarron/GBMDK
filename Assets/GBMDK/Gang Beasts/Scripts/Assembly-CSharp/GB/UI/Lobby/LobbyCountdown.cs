using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GB.UI.Lobby
{
	public class LobbyCountdown : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCountdown_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float time;

			public LobbyCountdown _003C_003E4__this;

			public Action onComplete;

			private int _003ClastTime_003E5__2;

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
			public _003CCountdown_003Ed__5(int _003C_003E1__state)
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

		public bool playCountdownAudio;

		private Coroutine _countdown;

		public bool CountdownActive => false;

		public void StartCountdown(float countdown, Action onComplete)
		{
		}

		[IteratorStateMachine(typeof(_003CCountdown_003Ed__5))]
		private IEnumerator Countdown(float time, Action onComplete)
		{
			return null;
		}

		public void StopCountdown()
		{
		}

		private void SendTimer(int value)
		{
		}

		private void HideTimer()
		{
		}
	}
}
