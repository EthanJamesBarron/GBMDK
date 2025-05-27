using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CoreNet.StateSync.Syncs;
using CoreNet.StateSync.Triggers;
using UnityEngine;

namespace GB.Networking.Sync
{
	public class JointBreakSyncTrigger : BaseSyncTrigger, IAutoJointV2PrecopyEvent
	{
		[CompilerGenerated]
		private sealed class _003CIEnumeratorCheckBreak_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public JointBreakSyncTrigger _003C_003E4__this;

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
			public _003CIEnumeratorCheckBreak_003Ed__31(int _003C_003E1__state)
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
		private Joint _joint;

		[SerializeField]
		private TransformSync _syncTarget;

		private bool _cachedValues;

		private float _jointBreakValue;

		private float _jointTorqueBreakValue;

		[SerializeField]
		private float _randomBreakMin;

		[SerializeField]
		private float _randomBreakMax;

		[SerializeField]
		private float _randomTorqueMin;

		[SerializeField]
		private float _randomTorqueMax;

		private JoinedRigidbodysStabilizer _stabilizer;

		private Coroutine _breakCheck;

		public TransformSync SyncTarget
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private static bool JointsActive => false;

		public Joint Joint
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void OnAutoJointV2Precopy(Joint newJoint)
		{
		}

		public override void OverrideSync(bool state)
		{
		}

		private void CacheJointValues()
		{
		}

		protected void DestroyJoint()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected void Start()
		{
		}

		private void OnDestroy()
		{
		}

		protected void SetupJoint()
		{
		}

		protected virtual void SetJointBreakValues()
		{
		}

		protected void InvulnJoint()
		{
		}

		private void FindJointStabilizer()
		{
		}

		private void OnJointBreak(float breakForce)
		{
		}

		[IteratorStateMachine(typeof(_003CIEnumeratorCheckBreak_003Ed__31))]
		private IEnumerator IEnumeratorCheckBreak()
		{
			return null;
		}

		private void CheckBreak()
		{
		}

		protected virtual void OnBreak()
		{
		}
	}
}
