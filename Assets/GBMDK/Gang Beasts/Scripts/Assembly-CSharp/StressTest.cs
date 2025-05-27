using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class StressTest : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CFPS_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StressTest _003C_003E4__this;

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
		public _003CFPS_003Ed__13(int _003C_003E1__state)
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

	public GameObject[] prefab;

	public Vector3 spawnPoint;

	public int rbCount;

	public int increaseAmount;

	public Text fpsCounter;

	public Text rbCounter;

	public Text timeStep;

	public float frequency;

	public int nbDecimal;

	private float accum;

	private int frames;

	private void Start()
	{
	}

	public void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CFPS_003Ed__13))]
	private IEnumerator FPS()
	{
		return null;
	}
}
