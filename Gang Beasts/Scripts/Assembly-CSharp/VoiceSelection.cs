using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Costumes;
using Femur;
using UnityEngine;
using UnityEngine.EventSystems;

public class VoiceSelection : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CChangeVoiceRoutine_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MoveDirection dir;

		public VoiceSelection _003C_003E4__this;

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
		public _003CChangeVoiceRoutine_003Ed__14(int _003C_003E1__state)
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

	public ControllerButtons ControllerButtons;

	public EffectsHandeler.VoiceType PreviewType;

	public Actor.Voice DefaultVoice;

	public Actor.Voice[] AllowedVoices;

	public bool ForceActorEmotes;

	public SelectedMenuInputEvent selectedMenuInputEvent;

	private EffectsHandeler EffectsHandeler;

	private void Awake()
	{
	}

	private void Selected()
	{
	}

	private void Start()
	{
	}

	public void Update()
	{
	}

	public void ResetVoice()
	{
	}

	private void ChangeVoice(MoveDirection dir)
	{
	}

	[IteratorStateMachine(typeof(_003CChangeVoiceRoutine_003Ed__14))]
	private IEnumerator ChangeVoiceRoutine(MoveDirection dir)
	{
		return null;
	}

	private Actor.Voice GetNextAllowedVoice(Actor.Voice voice, bool previous = false)
	{
		return default(Actor.Voice);
	}

	private bool IsValidVoice(Actor.Voice voice)
	{
		return false;
	}
}
