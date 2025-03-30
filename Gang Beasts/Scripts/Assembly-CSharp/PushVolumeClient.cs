using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PushVolumeClient : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDegradeForce_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PushVolumeClient _003C_003E4__this;

		private float _003Ctimer_003E5__2;

		private float _003CdelayTime_003E5__3;

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
		public _003CDegradeForce_003Ed__15(int _003C_003E1__state)
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

	public float forceOverrideMultiplier;

	[SerializeField]
	private bool degradeAfterFirstForce;

	[SerializeField]
	private float degradationDelayTime;

	[SerializeField]
	private float degradationDelayVariance;

	[SerializeField]
	private float degradationTime;

	private PushVolume[] volumes;

	[HideInInspector]
	public Rigidbody rb;

	[HideInInspector]
	public Transform t;

	public Transform[] floatPoints;

	private float startingMultiplier;

	private bool hasBeenForceAffected;

	private bool hasStartedDecaying;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void NotifyForceActive()
	{
	}

	[IteratorStateMachine(typeof(_003CDegradeForce_003Ed__15))]
	private IEnumerator DegradeForce()
	{
		return null;
	}

	private void OnDrawGizmosSelected()
	{
	}

	public bool HasStartedDecaying()
	{
		return false;
	}
}
