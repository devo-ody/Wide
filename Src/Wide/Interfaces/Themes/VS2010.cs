﻿#region License
// Copyright (c) 2013 Chandramouleswaran Ravichandran
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
#endregion
using System;
using System.Collections.Generic;

namespace Wide.Interfaces.Themes
{
    /// <summary>
    /// Class VS2010
    /// </summary>
    public sealed class VS2010 : ITheme
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VS2010"/> class.
        /// </summary>
        public VS2010()
        {
            UriList = new List<Uri>
                          {
                              new Uri("pack://application:,,,/Xceed.Wpf.AvalonDock.Themes.VS2010;component/Theme.xaml"),
                              new Uri("pack://application:,,,/Wide;component/Interfaces/Styles/VS2010/Theme.xaml")
                          };
        }

        #region ITheme Members
        /// <summary>
        /// Lists of valid URIs which will be loaded in the theme dictionary
        /// </summary>
        /// <value>The URI list.</value>
        public IList<Uri> UriList { get; private set; }

        /// <summary>
        /// The name of the theme - "VS2010"
        /// </summary>
        /// <value>The name.</value>
        public string Name
        {
            get { return "VS2010"; }
        }
        #endregion
    }
}