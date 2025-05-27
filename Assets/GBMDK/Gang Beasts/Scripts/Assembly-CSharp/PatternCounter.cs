using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SynchronizerData;
using UnityEngine;

public class PatternCounter : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPatternCheck_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PatternCounter _003C_003E4__this;

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
		public _003CPatternCheck_003Ed__13(int _003C_003E1__state)
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

	public BeatValue[] beatValues;

	public int beatScalar;

	public float loopTime;

	public AudioSource audioSource;

	public GameObject[] observers;

	private float nextBeatSample;

	private float[] samplePeriods;

	private int sequenceIndex;

	private float currentSample;

	private void Awake()
	{
	}

	private void StartPatternCheck(double syncTime)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CPatternCheck_003Ed__13))]
	private IEnumerator PatternCheck()
	{
		return null;
	}
}
