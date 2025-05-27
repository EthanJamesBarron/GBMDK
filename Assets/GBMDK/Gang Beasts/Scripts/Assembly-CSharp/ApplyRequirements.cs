using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Costumes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ApplyRequirements : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CdelaySelect_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ApplyRequirements _003C_003E4__this;

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
		public _003CdelaySelect_003Ed__12(int _003C_003E1__state)
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

	public Button DisabledButtonSelect;

	private Button _applyButton;

	private TextMeshProUGUI _text;

	private Color defaultColor;

	public Color disabledColor;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void CheckInteractable()
	{
	}

	private bool ShouldBeInteractable()
	{
		return false;
	}

	private void OnDestroy()
	{
	}

	[IteratorStateMachine(typeof(_003CdelaySelect_003Ed__12))]
	private IEnumerator delaySelect()
	{
		return null;
	}
}
