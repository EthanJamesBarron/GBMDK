using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GB.View.UI
{
	public class UISafeZoneSizer : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CUpdateTargetOffsets_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UISafeZoneSizer _003C_003E4__this;

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
			public _003CUpdateTargetOffsets_003Ed__8(int _003C_003E1__state)
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

		[SerializeField]
		private RectTransform _target;

		[SerializeField]
		private RectTransform _parent;

		[SerializeField]
		private Vector2 _insetAmount;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void PlatformEvents_OnPlatformGamePauseEvent(bool effect)
		{
		}

		private void OnEnable()
		{
		}

		private void OnRectTransformDimensionsChange()
		{
		}

		[IteratorStateMachine(typeof(_003CUpdateTargetOffsets_003Ed__8))]
		private IEnumerator UpdateTargetOffsets()
		{
			return null;
		}
	}
}
