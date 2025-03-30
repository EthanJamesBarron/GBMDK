using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;

namespace GB.Utils
{
	public class PeripheralMonitoring : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDelayedStateUpdate_003Ed__95 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PeripheralMonitoring _003C_003E4__this;

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
			public _003CDelayedStateUpdate_003Ed__95(int _003C_003E1__state)
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

		private static readonly string[] TRACKERLESS_DEVICES;

		public float interval;

		public bool enableInEditor;

		public bool useFakeHMDPresent;

		public bool useFakeHMDPresentAtStartup;

		public bool useFakeTrackerPresent;

		public bool useFakeContPresent;

		public bool useFakeInFocus;

		public bool useFakeUserPresent;

		public bool fakeHMDPresent;

		public bool fakeHMDPresentAtStartup;

		public bool fakeTrackerPresent;

		public bool fakeContPresent;

		public bool fakeInFocus;

		public bool fakeUserPresent;

		private bool hmdReallyPresent;

		private bool hmdReallyPresentAtStartup;

		private bool trackerReallyPresent;

		private bool controllerReallyPresent;

		private bool reallyInFocus;

		private bool hmdReallyUserPresent;

		private static bool checkedHMDPresentAtStartup;

		private List<UnityEngine.XR.InputDevice> _devices;

		private PeripheralMonitoring _monitor;

		private List<XRNodeState> _nodeStates;

		public PeripheralMonitoring _Monitor => null;

		public bool hmdPresent => false;

		public bool hmdPresentAtStartup => false;

		public bool trackerPresent => false;

		public bool hmdUserPresent => false;

		public bool controllerPresent => false;

		public bool inFocus => false;

		public bool allPresent => false;

		private bool effectiveHMDPresent => false;

		private bool effectiveHMDPresentAtStartup => false;

		private bool effectiveTrackerPresent => false;

		private bool effectiveControllerPresent => false;

		private bool effectiveInFocus => false;

		private bool effectiveHDMUserPresent => false;

		public event Action gotHMD
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action gotTracker
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action gotController
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action gotFocus
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action gotHMDUserPresent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action gotAny
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action lostHMD
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action lostTracker
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action lostController
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action lostFocus
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action lostHMDUserPresent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action lostAny
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private static bool TrackerDeviceNeeded(string device)
		{
			return false;
		}

		private bool EffectivePresence(bool useFake, bool fake, bool real)
		{
			return false;
		}

		private void Awake()
		{
		}

		private void RegisterInputEvents()
		{
		}

		private void OnControllerConnected(in UnityEngine.InputSystem.InputDevice device, int userIndex)
		{
		}

		private void OnControllerDisconnected(in UnityEngine.InputSystem.InputDevice device, int userIndex)
		{
		}

		[IteratorStateMachine(typeof(_003CDelayedStateUpdate_003Ed__95))]
		private IEnumerator DelayedStateUpdate()
		{
			return null;
		}

		private void TriggerStateUpdate(XRNodeState obj)
		{
		}

		private void UpdateStates()
		{
		}

		private void OnDestroy()
		{
		}

		private void GamePaused(bool paused)
		{
		}

		private void CheckPresence(bool presentNow, ref bool wasPresent, Action onGotten, Action onLost)
		{
		}
	}
}
