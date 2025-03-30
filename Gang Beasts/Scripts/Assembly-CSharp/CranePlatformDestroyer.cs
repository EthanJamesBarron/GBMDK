using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;

public class CranePlatformDestroyer : MonoBehaviour
{
	[Serializable]
	public class DestroyGroup
	{
		public List<DestroyData> data;

		public float Delay;
	}

	[Serializable]
	public class DestroyData
	{
		public Rigidbody rigidBody;

		public Joint[] joints;
	}

	[CompilerGenerated]
	private sealed class _003CBreakJointsLogic_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CranePlatformDestroyer _003C_003E4__this;

		private float _003CvelMult_003E5__2;

		private DestroyGroup _003CcurrDest_003E5__3;

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
		public _003CBreakJointsLogic_003Ed__32(int _003C_003E1__state)
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
	private sealed class _003CPlayCreakingSounds_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CPlayCreakingSounds_003Ed__33(int _003C_003E1__state)
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
	public List<DestroyGroup> Destroyables;

	public float minVelocityMult;

	public float maxVelocityMult;

	public float breakingJointsVolume;

	public float minBreakGap;

	public float maxBreakGap;

	public AudioMixerGroup mixerGroup;

	private float breakTimer;

	private float breakTime;

	public SceneAudioClip creakingSound;

	public AudioClip[] creakingAudioClips;

	public Transform breakingPosition;

	public AudioClip[] breakingAudioClips;

	private List<Joint> otherJoints;

	public Rigidbody[] otherJointsBody;

	public float minVariance;

	public float maxVariance;

	private bool hasTriggered;

	private bool lastBreakHappend;

	private bool playCreakingSoundsOnce;

	private bool ready;

	private int breakIndex;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider collider)
	{
	}

	private void DelayGetJoints()
	{
	}

	private void BreakJoint(Joint target, Rigidbody body, bool playAudio = false, bool setAngular = false, float velocityMultiplier = 2f)
	{
	}

	private void BreakJoint(Joint target, bool playAudio = false, bool setAngular = false)
	{
	}

	[ContextMenu("Break")]
	private void BreakStairs()
	{
	}

	[IteratorStateMachine(typeof(_003CBreakJointsLogic_003Ed__32))]
	private IEnumerator BreakJointsLogic()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPlayCreakingSounds_003Ed__33))]
	private IEnumerator PlayCreakingSounds()
	{
		return null;
	}

	private void BreakRandomJoint()
	{
	}

	private void PopulateOtherJoints()
	{
	}
}
