using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CoreNet.Threading
{
	public class UnityThreadHandler : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDelayAction_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public Action action;

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
			public _003CDelayAction_003Ed__11(int _003C_003E1__state)
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

		private ConcurrentQueue<Action> QueuedActions;

		private static UnityThreadHandler _instance;

		public static UnityThreadHandler Instance
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void QueueEvent(Action function)
		{
		}

		public void FlushEvents()
		{
		}

		public static void ExternalDelay(float delay, Action action)
		{
		}

		[IteratorStateMachine(typeof(_003CDelayAction_003Ed__11))]
		public static IEnumerator DelayAction(float delay, Action action)
		{
			return null;
		}

		public static void ExternalCoroutine(IEnumerator coroutine)
		{
		}
	}
}
