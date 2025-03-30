using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Femur;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Costumes
{
	public class CostumeCustomization : MonoBehaviour
	{
		public enum CostumeActions
		{
			Reset = 0,
			NexTint = 1,
			PrevTint = 2
		}

		public delegate void ItemChanged();

		[Serializable]
		public class SlotButton
		{
			public ControllerButtons ControllerButton;

			public SelectedMenuInputEvent Reset;

			public SelectedMenuInputEvent NextTint;

			public SelectedMenuInputEvent RightButton;

			public SelectedMenuInputEvent LeftButton;

			public CostumeParts PrimaryPart;

			public GameObject BaseHilightGameObject;
		}

		public class Slot
		{
			[CompilerGenerated]
			private sealed class _003CHilightSelectedSlotEnumerator_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public Slot _003C_003E4__this;

				public ActorCostume actorCostume;

				public float duration;

				public Color hilight;

				private List<Color> _003Ccolors_003E5__2;

				private List<Material> _003Cmaterials_003E5__3;

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
				public _003CHilightSelectedSlotEnumerator_003Ed__26(int _003C_003E1__state)
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

			public SlotButton SlotButton;

			public int SlotIndex;

			public RigCombine.CombinedObject DefaulItem;

			public List<CostumeObject> Items;

			public List<int> DeactivatedSlots;

			public List<int> DeactivatedBy;

			private ushort _userSelectedTint;

			private int _currentIndex;

			private bool _active;

			private bool _hilightRunning;

			private float timeElapsed;

			public ushort UserSelectedTint
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public int CurrentIndex => 0;

			public bool Active
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public Slot(SlotButton slotButton)
			{
			}

			public CostumeObject GetCurrentCostumeObject()
			{
				return null;
			}

			public void NextItem()
			{
			}

			public void PreviousItem()
			{
			}

			public void SetItemIndex(int index)
			{
			}

			public void ReactiveSlot(int index)
			{
			}

			public void HilightSelectedSlot(MonoBehaviour coroutineRunner, ActorCostume actorCostume, Color hilight, float duration = 1f)
			{
			}

			[IteratorStateMachine(typeof(_003CHilightSelectedSlotEnumerator_003Ed__26))]
			private IEnumerator HilightSelectedSlotEnumerator(ActorCostume actorCostume, float duration, Color hilight)
			{
				return null;
			}

			private List<Material> GetMaterials(GameObject[] gameObjects)
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CApplyCostumeInternal_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CostumeCustomization _003C_003E4__this;

			public Action onLoadedAction;

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
			public _003CApplyCostumeInternal_003Ed__49(int _003C_003E1__state)
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

		public bool EnableHilight;

		public Color HilightColor;

		public float HilightTime;

		public bool AllowDisabledCostumes;

		public bool AllowLockedCostumes;

		public Actor BaseActorPrefab;

		public Transform ActorSpawnLoation;

		public SlotButton[] SlotButtons;

		[HideInInspector]
		public Actor actorInstance;

		public VoiceBubble voiceBubble;

		private ActorCostume _actorCostume;

		private int playerColorsIndex;

		private RemoveUnseenMesh _removeUnseenMesh;

		private SkinnedMeshRenderer actorBody;

		public List<Slot> Slots;

		private RigCombine _rigCombine;

		public Actor.Voice _voice;

		[HideInInspector]
		public int Voices;

		[HideInInspector]
		public string Name;

		private CostumeDatabase m_CostumeDatabase;

		private Coroutine _coroutineApplyCostume;

		public CostumeDatabase CostumeDatabase => null;

		public Actor.Voice Voice
		{
			get
			{
				return default(Actor.Voice);
			}
			set
			{
			}
		}

		public event ItemChanged OnItemChange
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

		public event ItemChanged OnVoiceChange
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

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void ChangeItem(MoveDirection dir, int index)
		{
		}

		public void Load(CostumeSaveEntry costumeSaveEntry)
		{
		}

		public void Randomize()
		{
		}

		public void Reset()
		{
		}

		public void Activate(bool active)
		{
		}

		public void resetActorPosistion()
		{
		}

		public void ActOnButtonInput(int index, CostumeActions actionIndex)
		{
		}

		public void ChangePlayerColor(bool next)
		{
		}

		public void SetSlotsOverideColors(int slotindex = -1)
		{
		}

		public void ApplyButtonSelected()
		{
		}

		public CostumeSaveEntry GetCostumeSaveObject()
		{
			return null;
		}

		private void ApplyCostume(Action onLoadedAction = null)
		{
		}

		[IteratorStateMachine(typeof(_003CApplyCostumeInternal_003Ed__49))]
		private IEnumerator ApplyCostumeInternal(Action onLoadedAction)
		{
			return null;
		}

		private void NextTint(int slotIndex, int change = 1)
		{
		}

		private void ResetSlot(int slotIndex)
		{
		}

		private void UpdateTintButton(int index)
		{
		}

		private bool IsTintable(int slotIndex)
		{
			return false;
		}

		private void HilightSelectedSlot(int slotindex)
		{
		}

		private void DeActiveConflictingSlots(int index)
		{
		}

		private void ReActiveConflictingSlots(int index)
		{
		}

		private void ClearActiveDeactiveConflictingSlots()
		{
		}
	}
}
