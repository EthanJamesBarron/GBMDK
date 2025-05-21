using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GB.Setup;
using UnityEngine;

namespace GB.Core.Loading
{
	public class LoadScreenSystem : MonoBehaviour, IAsyncResourceLoader
	{
		[CompilerGenerated]
		private sealed class _003CAwaitPrepPipeCompletion_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LoadScreenSystem _003C_003E4__this;

			public Action onComplete;

			private bool _003Ccomplete_003E5__2;

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
			public _003CAwaitPrepPipeCompletion_003Ed__51(int _003C_003E1__state)
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

		private const string LOADING_ADDRESSABLE_LABEL = "Loading";

		private float LoadScreenFadeTime;

		private List<IEnumerator> _showPrepPipePrimedActions;

		private float minimumLoadScreenTime;

		private float timeOnLoadScreen;

		private bool HideFadeActive;

		private bool ShowFadeActive;

		private Action internalOnHideCompleted;

		private Action internalOnShowCompleted;

		private bool loadScreenActive;

		private CameraClearFlags loadScreenClearFlags;

		private Color loadScreenBackgroundColour;

		private LayerMask loadScreenCullMask;

		private CameraClearFlags inGameClearFlags;

		private Color inGameClearColour;

		private LayerMask inGameCullMask;

		private LoadScreenDisplayHandler _displayHandlerRef;

		public bool LoadScreenActive => false;

		public LoadScreenDisplayHandler LoadingScreen => null;

		public static event Action PreLoadingScreenShown
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

		public static event Action OnLoadingScreenShown
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

		public static event Action OnLoadingScreenHidden
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

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		private void Awake()
		{
		}

		public void BeginAsyncLoading()
		{
		}

		public IList<object> GetAssetKeys()
		{
			return null;
		}

		public bool HasFinishedAsyncLoading()
		{
			return false;
		}

		public bool HasErrors()
		{
			return false;
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void RepositionImage()
		{
		}

		private void Update()
		{
		}

		public void PrepareEventResponses()
		{
		}

		private void RegisterEventResponsesClient()
		{
		}

		private void RegisterEventResponsesServer()
		{
		}

		private void OnJoinedGame()
		{
		}

		private void PrepareLoadScreen()
		{
		}

		private void OnNewLevelLoad()
		{
		}

		private void HidePersistantUI()
		{
		}

		public void OverrideStoredCameraDetails(LayerMask newMask, CameraClearFlags clearFlags)
		{
		}

		public void RegisterPrepPipeRequirement(IEnumerator coroutine)
		{
		}

		public void ShowLoadingScreen(float minimumDisplayTime, Action onCompleteResponse = null, float fadeTimeOverride = -1f, bool overridePrepPipe = false)
		{
		}

		public void HideLoadingScreen(Action onCompleteResponse = null, float fadeTimeOverride = -1f, bool forceOverride = false)
		{
		}

		[IteratorStateMachine(typeof(_003CAwaitPrepPipeCompletion_003Ed__51))]
		private IEnumerator AwaitPrepPipeCompletion(Action onComplete)
		{
			return null;
		}
	}
}
