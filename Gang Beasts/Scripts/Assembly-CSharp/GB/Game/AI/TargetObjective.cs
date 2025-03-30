using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Femur;
using UnityEngine;

namespace GB.Game.AI
{
	public class TargetObjective : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CObjectiveUpdateRoutine_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TargetObjective _003C_003E4__this;

			public Action<Actor, TargetObjective> OnComplete;

			private bool _003ChasCompletedGoal_003E5__2;

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
			public _003CObjectiveUpdateRoutine_003Ed__9(int _003C_003E1__state)
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

		private Actor _actorRef;

		private Coroutine objectiveUpdate;

		private AIBehaviourBase _objective;

		public bool ActiveRunning => false;

		public bool Targeted(Actor actor)
		{
			return false;
		}

		private void OnDisable()
		{
		}

		public void Initialize(Actor actor)
		{
		}

		public void SetObjective(AIBehaviourBase objective, Action<Actor, TargetObjective> OnComplete)
		{
		}

		[IteratorStateMachine(typeof(_003CObjectiveUpdateRoutine_003Ed__9))]
		private IEnumerator ObjectiveUpdateRoutine(Action<Actor, TargetObjective> OnComplete)
		{
			return null;
		}

		private void StopCurrentObjective()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
