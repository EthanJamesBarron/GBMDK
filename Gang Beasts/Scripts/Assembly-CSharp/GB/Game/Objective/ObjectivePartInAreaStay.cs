using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Femur;
using UnityEngine;

namespace GB.Game.Objective
{
	public class ObjectivePartInAreaStay : ObjectivePartInArea
	{
		[CompilerGenerated]
		private sealed class _003CTimerRoutine_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ObjectivePartInAreaStay _003C_003E4__this;

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
			public _003CTimerRoutine_003Ed__7(int _003C_003E1__state)
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

		private Coroutine timerRoutine;

		private float _curTime;

		public float stayTime;

		public int GetNumBeastsInArea => 0;

		protected override bool OnActorEntered(Actor actor)
		{
			return false;
		}

		protected override bool OnActorExited(Actor actor)
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CTimerRoutine_003Ed__7))]
		private IEnumerator TimerRoutine()
		{
			return null;
		}
	}
}
