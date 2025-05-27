using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SuperGenius.Scripts.Audio.ScriptableObjects;
using UnityEngine;

public class FractureShard : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDelayCheckJointBreaks_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FractureShard _003C_003E4__this;

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
		public _003CDelayCheckJointBreaks_003Ed__21(int _003C_003E1__state)
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
	private sealed class _003CCleanupRoutine_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FractureShard _003C_003E4__this;

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
		public _003CCleanupRoutine_003Ed__25(int _003C_003E1__state)
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

	public SoundEffectScriptable JointBreakSound;

	public bool CleanUp;

	public float MinCleanupDelay;

	public float MaxCleanupDelay;

	public bool CleanupEffect;

	public ParticleSystem CleanupParticleSystem;

	public SoundEffectScriptable _cleanupSoundEffectScriptable;

	private List<Joint> _jointList;

	private List<FractureShard> _connectedShard;

	private List<Joint> _connectedJoints;

	private bool _cleaningUp;

	private Coroutine _delayJointBreakCheck;

	private const int _fixedUpdatedToDelay = 2;

	private int _delayFixedUpdatedCount;

	private static int _lastBreakFrame;

	private void OnEnable()
	{
	}

	private void OnJointBreak(float breakForce)
	{
	}

	public void AddJoint(Joint joints)
	{
	}

	public void EvaluateJoints()
	{
	}

	private void Init()
	{
	}

	private void CollectJoints()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayCheckJointBreaks_003Ed__21))]
	private IEnumerator DelayCheckJointBreaks()
	{
		return null;
	}

	private void CheckJointBreaks()
	{
	}

	private void StartCleanup()
	{
	}

	private void PlayBreakSound()
	{
	}

	[IteratorStateMachine(typeof(_003CCleanupRoutine_003Ed__25))]
	private IEnumerator CleanupRoutine()
	{
		return null;
	}

	private void FinalizeCleanUp()
	{
	}
}
