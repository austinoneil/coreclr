// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false, AllowMultiple = false)]
    public sealed class TypeForwardedFromAttribute : Attribute
    {
        private string assemblyFullName;

        private TypeForwardedFromAttribute()
        {
            // Disallow default constructor
        }


        public TypeForwardedFromAttribute(string assemblyFullName)
        {
            if (String.IsNullOrEmpty(assemblyFullName))
            {
                throw new ArgumentNullException(nameof(assemblyFullName));
            }
            this.assemblyFullName = assemblyFullName;
        }

        public string AssemblyFullName
        {
            get
            {
                return assemblyFullName;
            }
        }
    }
}
