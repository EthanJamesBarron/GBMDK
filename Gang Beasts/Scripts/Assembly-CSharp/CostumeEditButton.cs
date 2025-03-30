using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;
using UnityEngine.UI;

[RequireComponent(typeof(TextMeshProUGUI))]
public class CostumeEditButton : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CUpdateText_Routine_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int index;

		public CostumeEditButton _003C_003E4__this;

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
		public _003CUpdateText_Routine_003Ed__9(int _003C_003E1__state)
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

	public LocalizedString EditString;

	public LocalizedString NewString;

	public LocalizeStringEvent localizeControl;

	public SaveSelection SaveSelection;

	private bool _isEditText;

	private Button button;

	public GameObject savesFullUI;

	private void Awake()
	{
	}

	private void UpdateButton(int index)
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateText_Routine_003Ed__9))]
	private IEnumerator UpdateText_Routine(int index)
	{
		return null;
	}

	private void UpdateButtonText(LocalizedString newText)
	{
	}
}
