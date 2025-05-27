using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class KinimaticDealy : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDisableKinimatic_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KinimaticDealy _003C_003E4__this;

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
		public _003CDisableKinimatic_003Ed__4(int _003C_003E1__state)
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

	public int Frames;

	private Rigidbody _rigidbody;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CDisableKinimatic_003Ed__4))]
	private IEnumerator DisableKinimatic()
	{
		return null;
	}
}
