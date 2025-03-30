using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GB.Input
{
	public class ModalWindow : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003COnEnableAsync_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ModalWindow _003C_003E4__this;

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
			public _003COnEnableAsync_003Ed__10(int _003C_003E1__state)
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

		public TextMeshProUGUI text;

		public Button confirmButton;

		public Button cancelButton;

		public GameObject defaultUIElement;

		private Action<UserResponse> responseCallback;

		private void OnEnable()
		{
		}

		public void OnConfirm()
		{
		}

		public void OnCancel()
		{
		}

		public void SetText(string text)
		{
		}

		public void SetResponseCallback(Action<UserResponse> responseCallback)
		{
		}

		[IteratorStateMachine(typeof(_003COnEnableAsync_003Ed__10))]
		private IEnumerator OnEnableAsync()
		{
			return null;
		}
	}
}
