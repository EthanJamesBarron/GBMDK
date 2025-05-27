using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Costumes;
using Femur;
using TMPro;
using UnityEngine;

public class VoiceBubble : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CShowBubble_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VoiceBubble _003C_003E4__this;

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
		public _003CShowBubble_003Ed__14(int _003C_003E1__state)
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

	public CostumeCustomization CostumeCustomization;

	public TextMeshProUGUI VoiceText;

	public float ScaleSpeed;

	private Actor.Voice _currentVoice;

	private bool _scaleIn;

	private float _showTimeLeft;

	[SerializeField]
	private float _showTime;

	private float _scaleTime;

	private Vector3 _vector3zero;

	private Vector3 _vector3one;

	private Coroutine _coroutine_ShowBubble;

	private void Start()
	{
	}

	public void OnVoiceDeselect()
	{
	}

	public void OnVoiceSelect()
	{
	}

	[IteratorStateMachine(typeof(_003CShowBubble_003Ed__14))]
	private IEnumerator ShowBubble()
	{
		return null;
	}

	private void Update()
	{
	}

	public void TriggerSpeechBubble()
	{
	}

	public void CloseSpeechBubble()
	{
	}

	private void UpdateVoice()
	{
	}
}
