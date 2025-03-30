using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SignBulbBreaker : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CBreakOuterBulbRoutine_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WaitForSeconds waitSeconds;

		public SignBulbBreaker _003C_003E4__this;

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
		public _003CBreakOuterBulbRoutine_003Ed__16(int _003C_003E1__state)
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
	private sealed class _003CBreakInnerBulbRoutine_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WaitForSeconds waitSeconds;

		public SignBulbBreaker _003C_003E4__this;

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
		public _003CBreakInnerBulbRoutine_003Ed__17(int _003C_003E1__state)
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

	private bool broken1;

	private bool broken2;

	private Renderer thisRenderer;

	private ParticleSystem thisParticleSystem;

	private Material[] m_InnerBulbMaterials;

	private Material[] m_OuterBulbMaterials;

	private WaitForSeconds waitBreakOuterBulb;

	private WaitForSeconds waitBreakInnerBulb;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnGameStart()
	{
	}

	private void OnJointBreak(float breakForce)
	{
	}

	public void BreakOuterBulb()
	{
	}

	public void BreakInnerBulb()
	{
	}

	[IteratorStateMachine(typeof(_003CBreakOuterBulbRoutine_003Ed__16))]
	private IEnumerator BreakOuterBulbRoutine(WaitForSeconds waitSeconds)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CBreakInnerBulbRoutine_003Ed__17))]
	private IEnumerator BreakInnerBulbRoutine(WaitForSeconds waitSeconds)
	{
		return null;
	}
}
