using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GB.Data.Loading;
using GB.Setup;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;

public class LocalizationLoader : MonoBehaviour, IAsyncResourceLoader
{
	[CompilerGenerated]
	private sealed class _003CDownloadLocalizations_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssetsDownloader downloader;

		public int startLoad;

		public int endLoad;

		public LocalizationLoader _003C_003E4__this;

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
		public _003CDownloadLocalizations_003Ed__5(int _003C_003E1__state)
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
	private sealed class _003CPreloadDefaultTable_003Ed__6<TTable, TEntry> : IEnumerator<object>, IEnumerator, IDisposable where TTable : DetailedLocalizationTable<TEntry> where TEntry : TableEntry
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LocalizedDatabase<TTable, TEntry> database;

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
		public _003CPreloadDefaultTable_003Ed__6(int _003C_003E1__state)
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

	private const string LOCALE_LABEL = "Locale";

	private const string STRING_TABLE_SHARED_DATA_ADDRESS = "Assets/StringTable Shared Data.asset";

	public void Awake()
	{
	}

	public IList<object> GetAssetKeys()
	{
		return null;
	}

	public void OnDestroy()
	{
	}

	[IteratorStateMachine(typeof(_003CDownloadLocalizations_003Ed__5))]
	public IEnumerator DownloadLocalizations(AssetsDownloader downloader, int startLoad, int endLoad)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPreloadDefaultTable_003Ed__6<, >))]
	private IEnumerator PreloadDefaultTable<TTable, TEntry>(LocalizedDatabase<TTable, TEntry> database) where TTable : DetailedLocalizationTable<TEntry> where TEntry : TableEntry
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
}
