//
// Copyright (c) 2015 Towry Wang
// All rights reserved
//
//    http://github.com/towry/flash-message-csharp
// 
// Under MIT License
//

// Permission is hereby granted, free of charge, to any person obtaining a
// copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// FlashMessage
/// Display the message once
/// </summary>
public static class FlashMessage
{
    public static bool Has(this System.Web.UI.Page page)
    {
        if (page.Request.Cookies["flash_message"] != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void Flash(this System.Web.UI.Page page)
    {
        if (page.Request.Cookies["flash_message"] != null)
        {
            page.Response.Write(page.Request.Cookies["flash_message"].Value);
            HttpCookie ck = new HttpCookie("flash_message");
            ck.Expires = DateTime.Now.AddDays(-1d);
            page.Response.Cookies.Add(ck);
        }
    }

    public static void Flash(this System.Web.UI.Page page, string value)
    {
        page.Response.Cookies["flash_message"].Value = value;
        page.Response.Cookies["flash_message"].Expires = DateTime.Now.AddDays(7);
    }
}
