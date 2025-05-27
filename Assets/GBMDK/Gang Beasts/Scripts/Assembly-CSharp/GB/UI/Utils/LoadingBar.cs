using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace GB.UI.Utils
{
	public class LoadingBar : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass27_0
		{
			public bool isPendingRetry;

			internal void _003CActivateRetryUIAndWait_003Eb__0()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CActivateRetryUIAndWait_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LoadingBar _003C_003E4__this;

			private _003C_003Ec__DisplayClass27_0 _003C_003E8__1;

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
			public _003CActivateRetryUIAndWait_003Ed__27(int _003C_003E1__state)
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
		private Image _imageBackground;

		[SerializeField]
		private Image _imageFiller;

		[SerializeField]
		private Transform _targetScaler;

		[SerializeField]
		private GameObject _retryMessage;

		[SerializeField]
		private bool _fillX;

		[SerializeField]
		private bool _fillY;

		[SerializeField]
		private bool _filleZ;

		[SerializeField]
		private UnityEvent _onFinish;

		private Vector3 _startScale;

		private int _loadSteps;

		private Action _retryAction;

		private int _lastStep;

		private int _subStep;

		private int _totalSubSteps;

		public int LoadSteps
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int TotalSubSteps
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		public void UpdateLoad(float amount)
		{
		}

		public void IncreaseStep()
		{
		}

		public void UpdateLoad(int step)
		{
		}

		public void IncreaseSubStep()
		{
		}

		public void UpdateSubLoad(int step)
		{
		}

		public void ActivateRetryUI(Action onRetry)
		{
		}

		[IteratorStateMachine(typeof(_003CActivateRetryUIAndWait_003Ed__27))]
		public IEnumerator ActivateRetryUIAndWait()
		{
			return null;
		}

		private void OnRetry()
		{
		}
	}
}
