using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GB.Networking.Sync
{
	public class ReconnectableJointSyncTrigger : JointBreakSyncTrigger
	{
		[CompilerGenerated]
		private sealed class _003CDelayedReconnect_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ReconnectableJointSyncTrigger _003C_003E4__this;

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
			public _003CDelayedReconnect_003Ed__7(int _003C_003E1__state)
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

		private GameObject _object;

		private Rigidbody _reconnectTarget;

		private WaitForSeconds _reconnectWait;

		[SerializeField]
		private float _reconnectTime;

		protected override void OnEnable()
		{
		}

		public override void OverrideSync(bool state)
		{
		}

		protected override void OnBreak()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayedReconnect_003Ed__7))]
		protected IEnumerator DelayedReconnect()
		{
			return null;
		}

		public virtual void RecreateJoint()
		{
		}
	}
}
