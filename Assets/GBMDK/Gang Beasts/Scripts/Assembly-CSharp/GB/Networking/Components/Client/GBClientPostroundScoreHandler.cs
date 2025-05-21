using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CoreNet.Components;
using GB.Networking.Objects;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GB.Networking.Components.Client
{
	public class GBClientPostroundScoreHandler : NetComponent
	{
		[CompilerGenerated]
		private sealed class _003CDisplayScreen_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GBClientPostroundScoreHandler _003C_003E4__this;

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
			public _003CDisplayScreen_003Ed__28(int _003C_003E1__state)
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

		private static GBClientPostroundScoreHandler instance;

		private bool hasInitialSetup;

		private LayerMask UIMask;

		private Color CoinScreenBackgroundColour;

		private CameraClearFlags CoinScreenClearFlags;

		private LayerMask previousMask;

		private Color previousBGColor;

		private string uiCameraResource;

		private GameObject uiCamera;

		private bool _ShowScreen;

		private Coroutine _displayRunning;

		public static GBClientPostroundScoreHandler Instance => null;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private bool ScoreScreenBlocked()
		{
			return false;
		}

		private void OnGangAdded(NetGang item)
		{
		}

		private void OnGangUpdated(NetGang item)
		{
		}

		private void OnGangRemoved(NetGang item)
		{
		}

		private void LateUpdate()
		{
		}

		private void OnLevelChanged(Scene previous, Scene next)
		{
		}

		private void OnLevelBegin()
		{
		}

		private void OnNewLevelBegin()
		{
		}

		private void OnPostRoundBegin()
		{
		}

		private void StartDisplay()
		{
		}

		private void UpdateScoreboard(NetGang[] gangs)
		{
		}

		public void SetupCoinScreen()
		{
		}

		[IteratorStateMachine(typeof(_003CDisplayScreen_003Ed__28))]
		private IEnumerator DisplayScreen()
		{
			return null;
		}

		private void HideScreen()
		{
		}
	}
}
