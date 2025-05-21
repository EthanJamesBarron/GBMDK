using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;
using UnityEngine.InputSystem.Utilities;

namespace GB.Input
{
	public class SwitchControllerAssigner : IControllerAssigner
	{
		[CompilerGenerated]
		private sealed class _003CStartupAssignment_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SwitchControllerAssigner _003C_003E4__this;

			public UnityInputSystemManager manager;

			private ReadOnlyArray<InputDevice> _003Cdevices_003E5__2;

			private int _003Ci_003E5__3;

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
			public _003CStartupAssignment_003Ed__7(int _003C_003E1__state)
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

		private int _currentHandHeld;

		private InputDevice _handheldCache;

		private void OnControllerChanged(in InputDevice disconnectedDevice, int userIndex)
		{
		}

		private void ReassignHandHeld()
		{
		}

		public bool AssignController(UnityInputSystemManager manager, InputDevice device)
		{
			return false;
		}

		private int FindHandheld()
		{
			return 0;
		}

		[IteratorStateMachine(typeof(_003CStartupAssignment_003Ed__7))]
		public IEnumerator StartupAssignment(UnityInputSystemManager manager)
		{
			return null;
		}

		public bool SwitchDevices(UnityInputSystemManager manager, int oldIndex, int newIndex)
		{
			return false;
		}

		private void MultiPadOverrideCorrection()
		{
		}

		private bool CheckControllerOverrides(InputUser inputUser)
		{
			return false;
		}
	}
}
