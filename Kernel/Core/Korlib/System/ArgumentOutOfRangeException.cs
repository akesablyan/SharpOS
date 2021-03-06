//
// (C) 2006-2007 The SharpOS Project Team (http://www.sharpos.org)
//
// Authors:
//	Mircea-Cristian Racasan <darx_kies@gmx.net>
//
// Licensed under the terms of the GNU GPL v3,
//  with Classpath Linking Exception for Libraries
//

using SharpOS.AOT.Attributes;
using SharpOS.Korlib.Runtime;
using SharpOS.Kernel.ADC;

namespace InternalSystem {
	[TargetNamespace ("System")]
	public class ArgumentOutOfRangeException: InternalSystem.ArgumentException {
		public ArgumentOutOfRangeException ():
			this ("Argument is out of range.")
		{
		}

		public ArgumentOutOfRangeException (string paramName):
			base (paramName)
		{
		}

		public ArgumentOutOfRangeException (string paramName, string message):
			base (message)
		{
		}
	}
}
