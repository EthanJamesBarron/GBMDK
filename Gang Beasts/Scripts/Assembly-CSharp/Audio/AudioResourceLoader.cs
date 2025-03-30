using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GB.Core;
using GB.Setup;
using UnityEngine;

namespace Audio
{
	public class AudioResourceLoader : MonoBehaviour, IAsyncResourceLoader
	{
		[CompilerGenerated]
		private sealed class _003CLoadAudioConfigs_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AudioResourceLoader _003C_003E4__this;

			private LoadResourceTask<AudioConfig> _003CaudioConfigAsyncLoadRequest_003E5__2;

			private LoadResourceTask<JukeboxConfig> _003CjukeBoxAsyncLoadRequest_003E5__3;

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
			public _003CLoadAudioConfigs_003Ed__19(int _003C_003E1__state)
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

		private const string AUDIO_CONFIG_ADDRESS = "Core/Audio/AudioConfig.asset";

		private const string AUDIO_JUKEBOX_ADDRESS = "Core/Audio/JukeboxConfig.asset";

		private const string AUDIO_ADDRESSABLE_LABEL = "Audio";

		public static Action OnCurrentAudioDataChanged;

		private static AudioConfig _mapTracker;

		public static GlobalMusicConfig GlobalMusicData;

		public static TransitionTimes TransitionTimeData;

		public static UISoundConfig UISoundData;

		public static KOSoundConfig KOSoundConfig;

		public static SceneAudioConfig CurrentSceneAudioConfig;

		public static JukeboxConfig JukeboxData;

		private bool _isDone;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		public bool HasCompletedLoading()
		{
			return false;
		}

		public void Awake()
		{
		}

		public IList<object> GetAssetKeys()
		{
			return null;
		}

		public void BeginAsyncLoading()
		{
		}

		public bool HasFinishedAsyncLoading()
		{
			return false;
		}

		public bool HasErrors()
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CLoadAudioConfigs_003Ed__19))]
		private IEnumerator LoadAudioConfigs()
		{
			return null;
		}

		public void OnDestroy()
		{
		}

		public static SceneAudioConfig GetLevelData()
		{
			return null;
		}

		public void LevelChanged()
		{
		}
	}
}
