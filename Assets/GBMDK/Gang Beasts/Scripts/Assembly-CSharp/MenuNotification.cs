using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class MenuNotification : MonoBehaviour
{
	private class MenuNotificationObject
	{
		public float DisplayTime;

		public string DisplayText;

		public Color DisplayColor;

		public MenuNotificationObject(string displayText, float displayTime, Color displayColor)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CDisplayNotificaion_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MenuNotification _003C_003E4__this;

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
		public _003CDisplayNotificaion_003Ed__6(int _003C_003E1__state)
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

	public Text NotificationText;

	public Color DefaultNotificaionColor;

	private bool _notificationDisplaying;

	private List<MenuNotificationObject> menuNotificationObjectList;

	public void SendNotification(string notificationText, float nofifiacionTime = 2f, Color notificationColor = default(Color))
	{
	}

	public void OverrideNotification(string notificationText, float nofifiacionTime = 2f, Color notificationColor = default(Color))
	{
	}

	[IteratorStateMachine(typeof(_003CDisplayNotificaion_003Ed__6))]
	private IEnumerator DisplayNotificaion()
	{
		return null;
	}
}
