﻿/*
* PROJECT:          Atomix Development
* LICENSE:          Copyright (C) Atomix Development, Inc - All Rights Reserved
*                   Unauthorized copying of this file, via any medium is
*                   strictly prohibited Proprietary and confidential.
* PURPOSE:          Method Value MSIL
* PROGRAMMERS:      Aman Priyadarshi (aman.eureka@gmail.com)
*/

using System.Reflection;
using System.Runtime.InteropServices;

namespace Atomixilc.IL.CodeType
{
    internal class OpMethod : OpCodeType
    {
        internal readonly MethodBase Value;
        internal readonly int MethodUID;
        internal readonly CallingConvention CallingConvention;

        internal OpMethod(ILCode aCode, int aPosition, int aNextPosition, MethodBase aValue, ExceptionHandlingClause aEhc)
            :base(aCode, aPosition, aNextPosition, aEhc)
        {
            Value = aValue;
            MethodUID = aValue.GetHashCode();
            CallingConvention = CallingConvention.StdCall;

            var attrib = Value.GetCustomAttribute<DllImportAttribute>();
            if (attrib != null)
                CallingConvention = attrib.CallingConvention;
        }

        public override string ToString()
        {
            return string.Format("{0} [0x{1}-0x{2}] {3}", GetType().Name, Position.ToString("X4"), NextPosition.ToString("X4"), Value);
        }
    }
}
