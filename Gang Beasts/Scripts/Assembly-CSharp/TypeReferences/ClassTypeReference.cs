using System;
using UnityEngine;

namespace TypeReferences
{
	[Serializable]
	public sealed class ClassTypeReference : ISerializationCallbackReceiver
	{
		[SerializeField]
		private string _classRef;

		private Type _type;

		public Type Type
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string GetClassRef(Type type)
		{
			return null;
		}

		public ClassTypeReference()
		{
		}

		public ClassTypeReference(string assemblyQualifiedClassName)
		{
		}

		public ClassTypeReference(Type type)
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		public static implicit operator string(ClassTypeReference typeReference)
		{
			return null;
		}

		public static implicit operator Type(ClassTypeReference typeReference)
		{
			return null;
		}

		public static implicit operator ClassTypeReference(Type type)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
