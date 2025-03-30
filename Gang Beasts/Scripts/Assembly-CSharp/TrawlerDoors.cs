using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GB.Gamemodes;
using UnityEngine;

public class TrawlerDoors : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCloseDoor_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TrawlerDoors _003C_003E4__this;

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
		public _003CCloseDoor_003Ed__14(int _003C_003E1__state)
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

	public GameModeEnum validGameMode;

	public Rigidbody target;

	public ConfigurableJoint joint;

	private bool doorOpen;

	private int hasTriggered;

	private bool isActive;

	[SerializeField]
	private float _waitOpenTime;

	private WaitForSeconds _waitTime;

	private Coroutine _closeCheck;

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

	[IteratorStateMachine(typeof(_003CCloseDoor_003Ed__14))]
	private IEnumerator CloseDoor()
	{
		return null;
	}
}
