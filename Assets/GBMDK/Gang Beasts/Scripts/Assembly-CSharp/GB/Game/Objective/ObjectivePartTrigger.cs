using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Femur;
using UnityEngine;

namespace GB.Game.Objective
{
	public class ObjectivePartTrigger : ObjectivePart
	{
		[CompilerGenerated]
		private sealed class _003CStartCooldown_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ObjectivePartTrigger _003C_003E4__this;

			public Actor actor;

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
			public _003CStartCooldown_003Ed__4(int _003C_003E1__state)
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
		private bool _careForAlive;

		[SerializeField]
		private float _retriggerCooldown;

		protected List<Actor> _cooldowns;

		public void OnTriggerEnter(Collider other)
		{
		}

		[IteratorStateMachine(typeof(_003CStartCooldown_003Ed__4))]
		private IEnumerator StartCooldown(Actor actor)
		{
			return null;
		}

		protected virtual bool OnActorEntered(Actor actor)
		{
			return false;
		}
	}
}
