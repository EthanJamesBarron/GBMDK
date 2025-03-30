using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CoreNet.Objects;
using UnityEngine;
using UnityEngine.Networking;

namespace Audio
{
	public class MusicController : MonoBehaviour
	{
		public delegate void OnMusicChange(AudioSource aSideSource, AudioSource bSideSource, AudioSource drumSource);

		private enum State
		{
			Menu = 0,
			InGame = 1,
			Loading = 2,
			Paused = 3
		}

		[CompilerGenerated]
		private sealed class _003CTransitionToPaused_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private float _003Cvolume_003E5__2;

			private float _003Ctime_003E5__3;

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
			public _003CTransitionToPaused_003Ed__16(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CTransitionToInGame_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private float _003Ctime_003E5__2;

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
			public _003CTransitionToInGame_003Ed__17(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CTransitionToLoading_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MusicController _003C_003E4__this;

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
			public _003CTransitionToLoading_003Ed__25(int _003C_003E1__state)
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

		public static AudioSource _aSideSource;

		public static AudioSource _bSideSource;

		public static AudioSource _drumsSource;

		public static SceneAudioConfig _sceneConfig;

		private string _currentActiveScene;

		private State state;

		public static event OnMusicChange OnLevelMusicLoad
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

		private void Start()
		{
		}

		private void OnClientStarted()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		[IteratorStateMachine(typeof(_003CTransitionToPaused_003Ed__16))]
		private IEnumerator TransitionToPaused()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CTransitionToInGame_003Ed__17))]
		private IEnumerator TransitionToInGame()
		{
			return null;
		}

		private void TransitionToASide()
		{
		}

		private void TransitionToBSide()
		{
		}

		private void OnNewLevelSelected(NetString message, NetworkConnection conn)
		{
		}

		private void OnNewLevelSelected(string sceneName)
		{
		}

		private void OnAudioDataChanged()
		{
		}

		private void HandleNewLevelLoad()
		{
		}

		private void LoadNewTracks(SceneAudioConfig audioConfig)
		{
		}

		[IteratorStateMachine(typeof(_003CTransitionToLoading_003Ed__25))]
		private IEnumerator TransitionToLoading()
		{
			return null;
		}

		private void OnLoadingScreenDismissed()
		{
		}

		private void HandleSceneTransition()
		{
		}
	}
}
