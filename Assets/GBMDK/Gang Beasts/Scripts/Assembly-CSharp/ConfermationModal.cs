using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ConfermationModal : MonoBehaviour
{
	public delegate void Callback(bool accept);

	[CompilerGenerated]
	private sealed class _003CSelectButton_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ConfermationModal _003C_003E4__this;

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
		public _003CSelectButton_003Ed__9(int _003C_003E1__state)
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

	public Text TitleText;

	public Text BodyText;

	public Button OkButton;

	public Button BackButton;

	private Callback _callback;

	public void Activate(Callback callback, string title = "", string textBody = "")
	{
	}

	public void PressedOk()
	{
	}

	public void PressedBack()
	{
	}

	[IteratorStateMachine(typeof(_003CSelectButton_003Ed__9))]
	private IEnumerator SelectButton()
	{
		return null;
	}
}
