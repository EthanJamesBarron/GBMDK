using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GB.Example
{
	public class ExampleGoalBehaviour : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDelayLightDisable_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public ExampleGoalBehaviour _003C_003E4__this;

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
			public _003CDelayLightDisable_003Ed__3(int _003C_003E1__state)
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
		private Light[] targetLights;

		public void EnableLights()
		{
		}

		public void DisableLights(float delay)
		{
		}

		[IteratorStateMachine(typeof(_003CDelayLightDisable_003Ed__3))]
		private IEnumerator DelayLightDisable(float delay)
		{
			return null;
		}
	}
}
