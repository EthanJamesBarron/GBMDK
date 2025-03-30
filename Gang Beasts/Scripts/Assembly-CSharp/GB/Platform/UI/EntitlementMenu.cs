using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GB.View.UI;
using UnityEngine.UI;

namespace GB.Platform.UI
{
	public class EntitlementMenu : UIController
	{
		[CompilerGenerated]
		private sealed class _003CSelectButton_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public EntitlementMenu _003C_003E4__this;

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
			public _003CSelectButton_003Ed__2(int _003C_003E1__state)
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

		public Selectable SelectOnEneable;

		private void OnEnable()
		{
		}

		[IteratorStateMachine(typeof(_003CSelectButton_003Ed__2))]
		private IEnumerator SelectButton()
		{
			return null;
		}

		private void Update()
		{
		}

		public void ButtonStore()
		{
		}

		public void ButtonSupport()
		{
		}

		public void ButtonExit()
		{
		}
	}
}
