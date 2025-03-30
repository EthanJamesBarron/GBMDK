using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace GB.Input
{
	public class GeneralControllerAssigner : IControllerAssigner
	{
		[CompilerGenerated]
		private sealed class _003CStartupAssignment_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GeneralControllerAssigner _003C_003E4__this;

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
			public _003CStartupAssignment_003Ed__8(int _003C_003E1__state)
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

		private static readonly Type[] COMPUTER_CONTROLLERS;

		private Type[] _blockList;

		private Type[] _pairTypeList;

		public GeneralControllerAssigner()
		{
		}

		public GeneralControllerAssigner(Type[] blockList, Type[] pairTypeList)
		{
		}

		private bool IsBlocked(Type type)
		{
			return false;
		}

		private bool IsPair(Type type, out Type other)
		{
			other = null;
			return false;
		}

		public bool AssignController(UnityInputSystemManager manager, InputDevice device)
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CStartupAssignment_003Ed__8))]
		public IEnumerator StartupAssignment(UnityInputSystemManager manager)
		{
			return null;
		}

		public bool SwitchDevices(UnityInputSystemManager manager, int oldIndex, int newIndex)
		{
			return false;
		}

		public static bool DefaultSwitchDevices(UnityInputSystemManager manager, int oldIndex, int newIndex)
		{
			return false;
		}
	}
}
