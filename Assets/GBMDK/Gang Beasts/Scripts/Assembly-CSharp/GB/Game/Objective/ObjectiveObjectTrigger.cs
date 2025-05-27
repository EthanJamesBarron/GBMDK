using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GB.Game.Objective
{
	public class ObjectiveObjectTrigger : ObjectivePart
	{
		[CompilerGenerated]
		private sealed class _003CStartCooldown_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ObjectiveObjectTrigger _003C_003E4__this;

			public ObjectiveObject objectiveObj;

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
		private float _retriggerCooldown;

		[SerializeField]
		private List<int> _objectIDs;

		private List<ObjectiveObject> _cooldowns;

		public void OnTriggerEnter(Collider other)
		{
		}

		[IteratorStateMachine(typeof(_003CStartCooldown_003Ed__4))]
		private IEnumerator StartCooldown(ObjectiveObject objectiveObj)
		{
			return null;
		}

		protected virtual void OnObjectEntered(ObjectiveObject objectiveObj)
		{
		}
	}
}
