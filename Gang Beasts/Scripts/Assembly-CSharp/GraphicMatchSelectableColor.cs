using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GraphicMatchSelectableColor : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSetColor_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Color color;

		public GraphicMatchSelectableColor _003C_003E4__this;

		public bool revert;

		public float revertTime;

		private float _003CtotalTime_003E5__2;

		private Color _003CtargetColor_003E5__3;

		private Color _003CstartingColor_003E5__4;

		private Color _003CcurrentColor_003E5__5;

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
		public _003CSetColor_003Ed__18(int _003C_003E1__state)
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

	public Selectable TargetSelectable;

	[Tooltip("Will use graphic on this GameObject if not set.!")]
	public Graphic Graphic;

	private bool _interactable;

	private Color _graphicOrigColor;

	private Color _larpedColor;

	private bool _selected;

	public void Awake()
	{
	}

	public void Start()
	{
	}

	public void Update()
	{
	}

	public void OnSelect(BaseEventData arg0)
	{
	}

	public void OnDeselect(BaseEventData arg0)
	{
	}

	public void OnPinterEnter(BaseEventData arg0)
	{
	}

	public void OnPointerExit(BaseEventData arg0)
	{
	}

	public void OnSubmit(BaseEventData arg0)
	{
	}

	public void OnInteractableChange()
	{
	}

	public void OnDisable()
	{
	}

	private bool CheckTransitionType()
	{
		return false;
	}

	private void StartSetColor(Color color, bool revert = false, float revertTime = 0.05f)
	{
	}

	[IteratorStateMachine(typeof(_003CSetColor_003Ed__18))]
	private IEnumerator SetColor(Color color, bool revert = false, float revertTime = 0.05f)
	{
		return null;
	}
}
