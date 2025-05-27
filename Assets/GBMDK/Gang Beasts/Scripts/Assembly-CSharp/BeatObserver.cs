using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SynchronizerData;
using UnityEngine;

public class BeatObserver : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitOnBeat_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BeatObserver _003C_003E4__this;

		public BeatType beatType;

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
		public _003CWaitOnBeat_003Ed__5(int _003C_003E1__state)
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

	[Range(0f, 500f)]
	public float beatWindow;

	[HideInInspector]
	public BeatType beatMask;

	private void Start()
	{
	}

	public void BeatNotify(BeatType beatType)
	{
	}

	public void BeatNotify()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitOnBeat_003Ed__5))]
	private IEnumerator WaitOnBeat(BeatType beatType)
	{
		return null;
	}
}
