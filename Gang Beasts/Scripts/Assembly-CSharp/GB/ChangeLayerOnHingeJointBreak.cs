using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GB
{
	[RequireComponent(typeof(HingeJoint))]
	public class ChangeLayerOnHingeJointBreak : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003COnJointBreak_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ChangeLayerOnHingeJointBreak _003C_003E4__this;

			private float _003Ctimer_003E5__2;

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
			public _003COnJointBreak_003Ed__4(int _003C_003E1__state)
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

		private HingeJoint _cachedJointRef;

		private Rigidbody _rb;

		[SerializeField]
		private float delay;

		private void Start()
		{
		}

		[IteratorStateMachine(typeof(_003COnJointBreak_003Ed__4))]
		private IEnumerator OnJointBreak()
		{
			return null;
		}
	}
}
