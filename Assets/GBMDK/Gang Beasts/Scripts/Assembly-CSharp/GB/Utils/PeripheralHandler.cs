using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace GB.Utils
{
	public class PeripheralHandler : MonoBehaviour
	{
		private enum PeripheralFailState
		{
			None = 0,
			Fading = 1,
			Shown = 2,
			Sleep = 3
		}

		[CompilerGenerated]
		private sealed class _003CHackSleep_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PeripheralHandler _003C_003E4__this;

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
			public _003CHackSleep_003Ed__24(int _003C_003E1__state)
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

		private PeripheralFailState currentState;

		private static PeripheralHandler _instance;

		[SerializeField]
		private LayerMask AlertUIMask;

		[SerializeField]
		private Color AlertBackgroundColour;

		[SerializeField]
		private CameraClearFlags AlertClearFlags;

		private LayerMask _previousMask;

		private Color _previousBackColour;

		private CameraClearFlags _previousClearFlags;

		[SerializeField]
		private TextMeshProUGUI AlertUIRef;

		[SerializeField]
		private Canvas _uiRoot;

		[SerializeField]
		private Camera _uiCamera;

		private GameObject _previousSelectable;

		private string _reason;

		private PeripheralFail _alertType;

		[SerializeField]
		private PeripheralMonitoring _monitor;

		public static PeripheralHandler Instance
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool AlertActive => false;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		public bool IsUserPresent()
		{
			return false;
		}

		private void Awake()
		{
		}

		[IteratorStateMachine(typeof(_003CHackSleep_003Ed__24))]
		private IEnumerator HackSleep()
		{
			return null;
		}

		private void Update()
		{
		}

		private void StartAlert(string message)
		{
		}

		private void FlipToAlert()
		{
		}

		private void FlipFromAlert(bool forceImmediate = false)
		{
		}

		private void AlertEnded()
		{
		}

		private void UpdateActiveCamera(Camera newCamera)
		{
		}
	}
}
