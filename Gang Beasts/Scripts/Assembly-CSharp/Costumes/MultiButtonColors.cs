using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Costumes
{
	public class MultiButtonColors : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler, IMoveHandler, ISubmitHandler
	{
		[Serializable]
		public class ButtonControls
		{
			public Button button;

			public MoveDirection SelectedDirection;
		}

		[CompilerGenerated]
		private sealed class _003CButtonColorOnPressed_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MultiButtonColors _003C_003E4__this;

			public Button button;

			public float time;

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
			public _003CButtonColorOnPressed_003Ed__16(int _003C_003E1__state)
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

		public ButtonControls[] buttons;

		public ColorBlock Cb;

		public float SelectedColorTime;

		private ColorBlock _cb;

		private Color _pressedColorTimeoutColor;

		private bool _enabledButtonsColors;

		public bool enabledButtonsColors
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		public void OnMove(AxisEventData axisEventData)
		{
		}

		public void OnSelect(BaseEventData eventData)
		{
		}

		public void OnDeselect(BaseEventData eventData)
		{
		}

		public void OnSubmit(BaseEventData eventData)
		{
		}

		private void SetButtonsColor(Color color)
		{
		}

		private void SetButtonColor(Button button, Color color)
		{
		}

		[IteratorStateMachine(typeof(_003CButtonColorOnPressed_003Ed__16))]
		private IEnumerator ButtonColorOnPressed(float time, Button button)
		{
			return null;
		}
	}
}
