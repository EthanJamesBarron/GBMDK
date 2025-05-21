using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[SingularComponent]
public class BulbBreaker : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CBreakBulbRoutine_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float waitSeconds;

		public BulbBreaker _003C_003E4__this;

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
		public _003CBreakBulbRoutine_003Ed__6(int _003C_003E1__state)
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

	public Material brokenMaterial;

	public GeneralAudioData bulbBreakAudioData;

	private bool broken;

	private Renderer thisRenderer;

	private ParticleSystem thisParticleSystem;

	private void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CBreakBulbRoutine_003Ed__6))]
	private IEnumerator BreakBulbRoutine(float waitSeconds)
	{
		return null;
	}

	public void BreakBulb()
	{
	}
}
