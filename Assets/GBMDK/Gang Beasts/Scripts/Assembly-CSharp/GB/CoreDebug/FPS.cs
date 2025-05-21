using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace GB.CoreDebug
{
	[RequireComponent(typeof(Text))]
	public class FPS : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CResetAveragedFPS_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FPS _003C_003E4__this;

			public float interval;

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
			public _003CResetAveragedFPS_003Ed__7(int _003C_003E1__state)
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

		private Text selfTextRef;

		private Coroutine resetRoutine;

		private List<float> CachedDeltas;

		private float weightedFPS;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		[IteratorStateMachine(typeof(_003CResetAveragedFPS_003Ed__7))]
		private IEnumerator ResetAveragedFPS(float interval)
		{
			return null;
		}
	}
}
