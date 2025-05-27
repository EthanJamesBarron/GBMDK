using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class NameEntry : MonoBehaviour
{
	public delegate void NameReturned(string name);

	public delegate void BackPressed();

	[CompilerGenerated]
	private sealed class _003CSetInputFeildSelection_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NameEntry _003C_003E4__this;

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
		public _003CSetInputFeildSelection_003Ed__14(int _003C_003E1__state)
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

	public InputField InputFieldRef;

	public Button OkButton;

	public Button BackButton;

	private NameReturned _nameReturned;

	private BackPressed _backPressed;

	private string _returnedInputFeildValue;

	public void Start()
	{
	}

	public void Activate(NameReturned nameReturned, BackPressed backPressed, string savedName = "")
	{
	}

	public void GetName(string inputFeildValue)
	{
	}

	public void ReturnName()
	{
	}

	public void PressedBack()
	{
	}

	public void InputFeildSelected()
	{
	}

	[IteratorStateMachine(typeof(_003CSetInputFeildSelection_003Ed__14))]
	public IEnumerator SetInputFeildSelection()
	{
		return null;
	}
}
