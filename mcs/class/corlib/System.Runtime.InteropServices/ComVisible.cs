//
// System.Runtime.InteropServices.ComVisible.cs
//
// Author:
//   Nick Drochak (ndrochak@gol.com)
//
// (C) 2002 Nick Drochak
//

using System;

namespace System.Runtime.InteropServices {

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class
		| AttributeTargets.Struct | AttributeTargets.Enum |
		AttributeTargets.Method | AttributeTargets.Property |
		AttributeTargets.Field | AttributeTargets.Interface |
		AttributeTargets.Delegate, Inherited=false)]
	public sealed class ComVisibleAttribute : Attribute 
	{
		private bool Visible = false;
		public ComVisibleAttribute(bool value) {Visible = value;}
		public bool Value { get {return Visible;} }
	}
}
