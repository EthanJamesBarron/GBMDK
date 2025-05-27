using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GB.Gamemodes;
using UnityEngine;

public class OnTriggerStayApplyForce : MonoBehaviour
{
	public enum ForceType
	{
		Linear = 0,
		Torque = 1
	}

	[CompilerGenerated]
	private sealed class _003CCloseDoor_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OnTriggerStayApplyForce _003C_003E4__this;

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
		public _003CCloseDoor_003Ed__21(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003COpenDoor_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OnTriggerStayApplyForce _003C_003E4__this;

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
		public _003COpenDoor_003Ed__22(int _003C_003E1__state)
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

	public Vector3 openForce;

	public Vector3 closeForce;

	public ForceType forceType;

	public GameModeEnum validGameMode;

	public Rigidbody target;

	private bool doorOpen;

	private int hasTriggered;

	private bool isActive;

	[SerializeField]
	private float _waitOpenTime;

	[SerializeField]
	private float _waitClosedTime;

	private WaitForSeconds _waitTime;

	private WaitForSeconds _waitTimeClosed;

	private Coroutine _closeCheck;

	private Coroutine _openCheck;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnTriggerEnter(Collider collider)
	{
	}

	private void OnTriggerExit(Collider collider)
	{
	}

	private void StartCloseCheck()
	{
	}

	private void StartOpenCheck()
	{
	}

	[IteratorStateMachine(typeof(_003CCloseDoor_003Ed__21))]
	private IEnumerator CloseDoor()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COpenDoor_003Ed__22))]
	private IEnumerator OpenDoor()
	{
		return null;
	}
}
