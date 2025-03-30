using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Costumes
{
	public class CostumeDatabase
	{
		[CompilerGenerated]
		private sealed class _003CLoad_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CostumeDatabase _003C_003E4__this;

			private AsyncOperationHandle<IList<CostumeObject>> _003Cop_003E5__2;

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
			public _003CLoad_003Ed__12(int _003C_003E1__state)
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

		public const string COSTUMES_LABEL = "Costume";

		public const string COSTUME_ITEMS_LABEL = "CostumeItem";

		private List<CostumeObject> CostumeObjects;

		private SortedList<uint, CostumeObject> searchSpeeder;

		private static CostumeDatabase _instance;

		private static readonly object _lock;

		public bool IsLoaded { get; private set; }

		public static CostumeDatabase Instance => null;

		[IteratorStateMachine(typeof(_003CLoad_003Ed__12))]
		public IEnumerator Load()
		{
			return null;
		}

		public CostumeObject GetCostumeObjectWithID(ushort id, bool isEnabled = false, bool isUnlocked = false)
		{
			return null;
		}

		public List<CostumeObject> GetAllCostumeObjects(bool isEnabled = true, bool isUnlocked = true)
		{
			return null;
		}

		private List<CostumeObject> GetEnabled(List<CostumeObject> costumeObjectList)
		{
			return null;
		}

		private List<CostumeObject> GetUnlocked(List<CostumeObject> costumeObjectList)
		{
			return null;
		}

		private bool IsUnlocked(CostumeObject costumeObject)
		{
			return false;
		}

		private void ParseCostumeOperationResult(IList<CostumeObject> result)
		{
		}
	}
}
