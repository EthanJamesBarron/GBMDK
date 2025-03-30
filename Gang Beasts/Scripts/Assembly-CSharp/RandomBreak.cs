using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[SingularComponent]
public class RandomBreak : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CBreakApplyForce_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RandomBreak _003C_003E4__this;

		public float impulseMultiplier;

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
		public _003CBreakApplyForce_003Ed__22(int _003C_003E1__state)
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
	private sealed class _003CBreakRoutine_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float waitSeconds;

		public RandomBreak _003C_003E4__this;

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
		public _003CBreakRoutine_003Ed__23(int _003C_003E1__state)
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

	[SerializeField]
	private float minBreakTime;

	[SerializeField]
	private float maxBreakTime;

	[SerializeField]
	private AnimationCurve timeWeightingCurve;

	[SerializeField]
	private bool _applyRandomTorqueOnBreak;

	[SerializeField]
	private bool _applyRandomVelocityOnBreak;

	[SerializeField]
	private float _randomTorqueMagnitude;

	[SerializeField]
	private float _randomVelocityManitude;

	[SerializeField]
	private AudioClip[] _breakNoiseClips;

	[SerializeField]
	private float _breakNoisePitchMin;

	[SerializeField]
	private float _breakNoisePitchMax;

	[SerializeField]
	private float _breakNoiseVolume;

	[SerializeField]
	private float _breakNoiseMaxDistance;

	private bool _broken;

	public Wheel Wheel;

	[HideInInspector]
	public List<Joint> ConnectedJoints;

	public bool IsBackFacing;

	public float ImpulseMagnitude;

	private Rigidbody _rigidbody;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	[ContextMenu("Break")]
	public void Break(float impulseMultiplier = 1f)
	{
	}

	private void OnJointBreak(float breakForce)
	{
	}

	[IteratorStateMachine(typeof(_003CBreakApplyForce_003Ed__22))]
	private IEnumerator BreakApplyForce(float impulseMultiplier)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CBreakRoutine_003Ed__23))]
	private IEnumerator BreakRoutine(float waitSeconds)
	{
		return null;
	}
}
