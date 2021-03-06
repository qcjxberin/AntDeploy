﻿#if NETSTANDARD

//
// System.Configuration.ConfigurationPropertyAttribute.cs
//
// Authors:
//	Duncan Mak (duncan@ximian.com)
//  Lluis Sanchez Gual (lluis@novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
// Copyright (C) 2004 Novell, Inc (http://www.novell.com)
//

namespace System.Configuration
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class ConfigurationPropertyAttribute : Attribute
    {
        public ConfigurationPropertyAttribute(string name)
        {
            Name = name;
        }

        public bool IsKey
        {
            get { return (Options & ConfigurationPropertyOptions.IsKey) != 0; }
            set
            {
                if (value) Options |= ConfigurationPropertyOptions.IsKey;
                else Options &= ~ConfigurationPropertyOptions.IsKey;
            }
        }

        public bool IsDefaultCollection
        {
            get { return (Options & ConfigurationPropertyOptions.IsDefaultCollection) != 0; }
            set
            {
                if (value) Options |= ConfigurationPropertyOptions.IsDefaultCollection;
                else Options &= ~ConfigurationPropertyOptions.IsDefaultCollection;
            }
        }

        public object DefaultValue { get; set; } = ConfigurationProperty.NoDefaultValue;

        public ConfigurationPropertyOptions Options { get; set; }

        public string Name { get; }

        public bool IsRequired
        {
            get { return (Options & ConfigurationPropertyOptions.IsRequired) != 0; }
            set
            {
                if (value) Options |= ConfigurationPropertyOptions.IsRequired;
                else Options &= ~ConfigurationPropertyOptions.IsRequired;
            }
        }
    }
}

#endif