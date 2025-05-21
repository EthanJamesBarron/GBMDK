using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Femur;
using UnityEngine;

namespace GB.Game.Tool.ActorEvents
{
	public class OnTriggerTimedEvent : OnActorEventBase, IActorOnTriggerEvent
	{
		[CompilerGenerated]
		private sealed class _003CTimerUpdate_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public OnTriggerTimedEvent _003C_003E4__this;

			public Actor actor;

			private float _003Ctimer_003E5__2;

			private int _003CnextlastShow_003E5__3;

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
			public _003CTimerUpdate_003Ed__4(int _003C_003E1__state)
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
		private float _timer;

		[SerializeField]
		private float _showIfUnder;

		private Dictionary<Actor, Coroutine> _activeBeasts;

		public void StartTimer(Actor actor)
		{
		}

		[IteratorStateMachine(typeof(_003CTimerUpdate_003Ed__4))]
		private IEnumerator TimerUpdate(Actor actor)
		{
			return null;
		}

		public void EndTimer(Actor actor, bool trigger)
		{
		}

		public void Event(Actor actor)
		{
		}
	}
}
