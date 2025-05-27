using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpawnInArea : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStartSpawn_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float time;

		public SpawnInArea _003C_003E4__this;

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
		public _003CStartSpawn_003Ed__6(int _003C_003E1__state)
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

	public GameObject[] meat;

	public Vector3 minVector;

	public Vector3 maxVector;

	public float minFrequency;

	public float maxFrequency;

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CStartSpawn_003Ed__6))]
	private IEnumerator StartSpawn(float time)
	{
		return null;
	}

	private void Spawn()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
