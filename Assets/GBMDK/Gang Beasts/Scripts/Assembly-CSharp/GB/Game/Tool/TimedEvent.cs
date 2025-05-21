using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace GB.Game.Tool
{
	public class TimedEvent : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CTimerLogic_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimedEvent _003C_003E4__this;

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
			public _003CTimerLogic_003Ed__11(int _003C_003E1__state)
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

		[SerializeField]
		private float _waitTime;

		[SerializeField]
		private UnityEvent _onStart;

		[SerializeField]
		private UnityEvent _onComplete;

		[SerializeField]
		private bool _completeIfStopped;

		[SerializeField]
		private bool _gameTime;

		private Coroutine _logic;

		public bool Running => false;

		private void OnDisable()
		{
		}

		public void StartTimer(bool restart)
		{
		}

		public void StopTimer()
		{
		}

		[IteratorStateMachine(typeof(_003CTimerLogic_003Ed__11))]
		private IEnumerator TimerLogic()
		{
			return null;
		}
	}
}
