using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Femur;
using UnityEngine;

namespace GB.Game.AI
{
	public class AIMoveObjective : AIBehaviourBase
	{
		[CompilerGenerated]
		private sealed class _003CWaitForAIToReachNode_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Actor actor;

			public AIMoveObjective _003C_003E4__this;

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
			public _003CWaitForAIToReachNode_003Ed__9(int _003C_003E1__state)
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
		private List<Transform> _aiMoveNodes;

		[SerializeField]
		private float distanceToNodeThreshold;

		[SerializeField]
		private bool _refreshCamera;

		private Transform _targetNode;

		private Coroutine _aiMoveCoroutine;

		public override void ExecuteBehaviour(Actor actor)
		{
		}

		private void StartAIMoveToPosition(Actor newActor)
		{
		}

		private void StartMoveCoroutine(Actor actor)
		{
		}

		public Transform GetRandomAIMoveNodeTransform()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CWaitForAIToReachNode_003Ed__9))]
		private IEnumerator WaitForAIToReachNode(Actor actor)
		{
			return null;
		}

		public void ReturnControl(Actor actor, TargetObjective objective)
		{
		}
	}
}
