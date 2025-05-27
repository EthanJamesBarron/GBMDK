using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CursorManagement : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CMouseAutoHide_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CursorManagement _003C_003E4__this;

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
		public _003CMouseAutoHide_003Ed__9(int _003C_003E1__state)
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

	public bool Enabled;

	public float DelayUntilHide;

	public Texture2D cursorTexture;

	public CursorMode cursorMode;

	public Vector2 hotSpot;

	private float idleMouseTime;

	private Vector2 lastMousePosition;

	public void Start()
	{
	}

	public void Enable(bool enable)
	{
	}

	[IteratorStateMachine(typeof(_003CMouseAutoHide_003Ed__9))]
	private IEnumerator MouseAutoHide()
	{
		return null;
	}

	public void SetLocked(bool locked)
	{
	}
}
