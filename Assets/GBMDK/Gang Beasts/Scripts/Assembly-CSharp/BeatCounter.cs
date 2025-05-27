using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SynchronizerData;
using UnityEngine;

public class BeatCounter : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CBeatCheck_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BeatCounter _003C_003E4__this;

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
		public _003CBeatCheck_003Ed__20(int _003C_003E1__state)
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

	public BeatValue beatValue;

	public float beatScalar;

	public BeatValue beatOffset;

	public bool negativeBeatOffset;

	public BeatType beatType;

	public float loopTime;

	public AudioSource audioSource;

	public GameObject[] observers;

	private float nextBeatSample;

	private float samplePeriod;

	private float sampleOffset;

	private float currentSample;

	private float unscaledSamplePeriod;

	private float unscaledSampleOffset;

	private float beatTime;

	public double GetNextBeatTime()
	{
		return 0.0;
	}

	private void Awake()
	{
	}

	private void StartBeatCheck(double syncTime)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CBeatCheck_003Ed__20))]
	private IEnumerator BeatCheck()
	{
		return null;
	}
}
