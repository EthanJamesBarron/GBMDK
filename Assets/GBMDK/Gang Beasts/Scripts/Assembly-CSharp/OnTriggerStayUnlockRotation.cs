using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GB.Gamemodes;
using UnityEngine;

public class OnTriggerStayUnlockRotation : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCloseDoor_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OnTriggerStayUnlockRotation _003C_003E4__this;

		private bool _003Ctest_003E5__2;

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
		public _003CCloseDoor_003Ed__22(int _003C_003E1__state)
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

	public float MinRotation;

	public float MaxRotation;

	public float targetStartRotation;

	public bool StartLocked;

	public HingeJoint TargetJoint;

	private int hasTriggered;

	private JointLimits targetLimits;

	public GameModeEnum validGameMode;

	private bool isActive;

	private bool doorUnlocked;

	[SerializeField]
	private float _waitOpenTime;

	private WaitForSeconds _waitTime;

	private Coroutine _closeCheck;

	private int HasTriggered
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	private void CalculateJointLimits(int shouldUnlock)
	{
	}

	private void SetJoinLimits()
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

	[IteratorStateMachine(typeof(_003CCloseDoor_003Ed__22))]
	private IEnumerator CloseDoor()
	{
		return null;
	}
}
