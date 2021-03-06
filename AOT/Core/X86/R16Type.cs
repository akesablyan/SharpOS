// 
// (C) 2006-2007 The SharpOS Project Team (http://www.sharpos.org)
//
// Authors:
//	Mircea-Cristian Racasan <darx_kies@gmx.net>
//
// Licensed under the terms of the GNU GPL v3,
//  with Classpath Linking Exception for Libraries
//

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Cecil.Metadata;

namespace SharpOS.AOT.X86 {
	public class R16Type : Register {
		/// <summary>
		/// Initializes a new instance of the <see cref="R16Type"/> class.
		/// </summary>
		/// <param name="name">The name of the register that is being referred to</param>
		/// <param name="index">An implementation-specific number used to encode this register to stream</param>
		public R16Type (string name, byte index)
			: base (name, index)
		{
		}
	}
}