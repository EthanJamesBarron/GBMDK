using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Costumes
{
	public class MoveSelectedButtonTo : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CMoveTo_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameObject go;

			public MoveSelectedButtonTo _003C_003E4__this;

			private RectTransform _003Crt_003E5__2;

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
			public _003CMoveTo_003Ed__22(int _003C_003E1__state)
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

		public GameObject ButtonsList;

		public float Speed;

		public RectTransform RectT;

		public RectTransform Mask;

		public float UpDownTolerance;

		public TextMeshProUGUI Up;

		public TextMeshProUGUI Down;

		public Button BackButton;

		public Button UpExit;

		public Button DownExit;

		private List<Button> _buttonList;

		private int _lastSelectedButtonIndex;

		private Color _upOrigColor;

		private Color _downOrigColor;

		public void Awake()
		{
		}

		public void ActivateButtonsList(List<Button> buttonsList = null)
		{
		}

		public void UpdateButtonsList(List<Button> buttonsList)
		{
		}

		public void DeactivateButtonsList()
		{
		}

		public void Update()
		{
		}

		public void AddButtonEvents()
		{
		}

		public void StartingButton(GameObject go)
		{
		}

		public void ButtonSelected(int index)
		{
		}

		[IteratorStateMachine(typeof(_003CMoveTo_003Ed__22))]
		private IEnumerator MoveTo(GameObject go)
		{
			return null;
		}

		public void SelectNextButton(bool down)
		{
		}

		public void SelectLastButton()
		{
		}

		private void GetButtonIndex(Button button)
		{
		}

		private void UpdateButtonNavigation()
		{
		}
	}
}
