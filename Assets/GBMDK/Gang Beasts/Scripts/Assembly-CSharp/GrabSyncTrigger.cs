using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CoreNet.StateSync.Triggers;
using UnityEngine;

[RequireComponent(typeof(GrabEvent))]
public class GrabSyncTrigger : BaseSyncTrigger
{
	[CompilerGenerated]
	private sealed class _003CDelayStopSync_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GrabSyncTrigger _003C_003E4__this;

		private int _003Cframes_003E5__2;

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
		public _003CDelayStopSync_003Ed__5(int _003C_003E1__state)
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

	public int SyncFramesOnRelease;

	private bool _grabed;

	public void Awake()
	{
	}

	public void OnGrab()
	{
	}

	public void OnRelease()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayStopSync_003Ed__5))]
	private IEnumerator DelayStopSync()
	{
		return null;
	}

	public void OnDestroy()
	{
	}
}
