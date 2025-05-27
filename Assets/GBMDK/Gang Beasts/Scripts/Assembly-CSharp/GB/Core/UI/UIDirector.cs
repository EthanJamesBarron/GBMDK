using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GB.Data.Loading;
using GB.Networking.Messaging.Messages;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace GB.Core.UI
{
	public class UIDirector : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CReselectHack_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIDirector _003C_003E4__this;

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
			public _003CReselectHack_003Ed__53(int _003C_003E1__state)
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
		private Canvas LevelLoadingCanvas;

		[SerializeField]
		private GameObject DefaultModalPrefab;

		[SerializeField]
		private ResourceCache _resources;

		public float blurTime;

		public string currentSceneName;

		private bool _showNameBars;

		private bool isMessageAllowed;

		private bool ShowModalBlocked;

		private string _onLoadscreenHidden_disconnectReason;

		private string _sceneChanged_disconnectReason;

		private List<ModalHandler> _currentModals;

		private Selectable _previousSelected;

		private Coroutine _ReselectorHack;

		private Canvas[] _previousCanvases;

		public ResourceCache Resources => null;

		public bool ShowingModal => false;

		public bool ShowNameBars
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event Action OnDisconnectUIClosed
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

		public event Action<string> OnDisconnectUIOverride
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

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public void RegisterWithNetworkManager()
		{
		}

		private void OnLoadingScreenShown()
		{
		}

		private void OnLoadingScreenHidden()
		{
		}

		private void OnPauseToggled()
		{
		}

		private void OnClientDisconnected(string message)
		{
		}

		private void SpawnDegradingMessage(NetServerMessage message)
		{
		}

		private void PlatformSystemMessenger_OnMessageChange(bool active)
		{
		}

		private void SceneManager_sceneLoaded(Scene arg0, LoadSceneMode arg1)
		{
		}

		public void HideCurrentModal()
		{
		}

		public void ShowCurrentModal()
		{
		}

		public void SetPreviousCanvasesActive(bool active)
		{
		}

		private void HandleFailedConnection()
		{
		}

		private void ForceBackToMenu()
		{
		}

		public void DisplayDisconnectModal(string reason)
		{
		}

		private void CreateDisconnectModal(string reason)
		{
		}

		private void CleanGameUI()
		{
		}

		public void CheckMenuForce()
		{
		}

		public void CreateYesNoModal(string title, string body, string yes, string no, Action yesAct, Action noAct, bool overrideLoad)
		{
		}

		private void ShowModalPreStep(Transform modalParent, bool showBlur)
		{
		}

		public void CreateNewModal(bool overrideLoading, params ModalSpawnParameters[] parameters)
		{
		}

		public void ForceModalCanvasReturn(Canvas[] newPreviousCanvases)
		{
		}

		public void ForceClearModal(ModalType type)
		{
		}

		public void AlertModalEnded(ModalHandler endedModal)
		{
		}

		private void StopReselectHack()
		{
		}

		[IteratorStateMachine(typeof(_003CReselectHack_003Ed__53))]
		private IEnumerator ReselectHack()
		{
			return null;
		}

		public void FlushModals()
		{
		}

		public bool AnyModalActive()
		{
			return false;
		}

		public T GetCurrentModalOfType<T>() where T : class
		{
			return null;
		}

		public void OverridePreviousSelected(Selectable newSelectable)
		{
		}

		public void ShowVROrientationModal()
		{
		}

		public void PlayTriggeredAudio(NetServerMessage message)
		{
		}

		public static void UILog(string message)
		{
		}
	}
}
