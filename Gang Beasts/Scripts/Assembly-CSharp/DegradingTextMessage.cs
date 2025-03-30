using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GB.Networking.Messaging.Messages;
using GB.View.UI;
using TMPro;
using UnityEngine;

public class DegradingTextMessage : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CRunLife_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DegradingTextMessage _003C_003E4__this;

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
		public _003CRunLife_003Ed__12(int _003C_003E1__state)
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

	private float _lifeTimer;

	private float _fadeTimer;

	[SerializeField]
	private TextMeshProUGUI _textComp;

	[SerializeField]
	private Canvas _canvas;

	[SerializeField]
	private UIControllerFallback _vrFallback;

	[SerializeField]
	private float _uiDeapth;

	private Vector3 _cachedOffset;

	private Coroutine activeMoveRoutine;

	private bool _worldSpace;

	public void StartLife(NetServerMessage message)
	{
	}

	public void StartLife(string customMessage, Color colour)
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CRunLife_003Ed__12))]
	private IEnumerator RunLife()
	{
		return null;
	}

	private void Cleanup()
	{
	}

	private void OnAnchorChanged()
	{
	}

	private void Update()
	{
	}

	private void UpdateRotation()
	{
	}

	private void UpdatePosition()
	{
	}
}
