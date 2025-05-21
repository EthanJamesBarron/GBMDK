using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Femur;
using UnityEngine;

namespace GB.Game.AI
{
	public class AITimedWaitObjective : AIBehaviourBase
	{
		[CompilerGenerated]
		private sealed class _003CWaitObjective_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AITimedWaitObjective _003C_003E4__this;

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
			public _003CWaitObjective_003Ed__7(int _003C_003E1__state)
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
		private float _waitDuration;

		private Coroutine _waitCoroutine;

		private WaitForSeconds _waitSeconds;

		protected override void Awake()
		{
		}

		public override void ExecuteBehaviour(Actor actor)
		{
		}

		private void StartWaitObjective(Actor newActor)
		{
		}

		private void StartWaitCoroutine()
		{
		}

		[IteratorStateMachine(typeof(_003CWaitObjective_003Ed__7))]
		private IEnumerator WaitObjective()
		{
			return null;
		}

		private void OnObjectiveComplete(Actor actor, TargetObjective objective)
		{
		}
	}
}
