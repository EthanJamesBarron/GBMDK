using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GB.DebugTools;
using UnityEngine;

public class TruckBase : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CBumpDelay_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TruckBase _003C_003E4__this;

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
		public _003CBumpDelay_003Ed__24(int _003C_003E1__state)
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

	private Transform thisTransform;

	private Rigidbody thisRigidbody;

	public float force;

	public Vector3 min;

	public Vector3 max;

	public bool outOfBounds;

	public int seed;

	private Vector3 startPos;

	[ReferenceDebugVariable(null, null, DebugVariables.DebugVariableCheckMode.None, updateMode = DebugVariables.DebugVariableCheckMode.PerFrame)]
	private Vector3 direction;

	public Rigidbody[] AttachedWheels;

	public float BumpFakeMinTime;

	public float BumpFakeMaxTime;

	public float BumpFakeForceMin;

	public float BumpFakeForceMax;

	private float nextBumpFakeTime;

	private float currentBumpFakeTime;

	private bool _Initialized;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void FixedUpdate()
	{
	}

	private void HandleFakeBump()
	{
	}

	public void NewDirection()
	{
	}

	public void AlignToVector(Rigidbody part, Vector3 alignmentVector, Vector3 targetVector, float stability, float speed)
	{
	}

	private void OnGameStart()
	{
	}

	[IteratorStateMachine(typeof(_003CBumpDelay_003Ed__24))]
	private IEnumerator BumpDelay()
	{
		return null;
	}
}
