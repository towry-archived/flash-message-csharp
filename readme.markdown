# FlashMessage

*Intro*: FlashMessage is a helper class used in asp.net webform 
to display message once.

I was helping my classmate to improve her asp.net website, but I am
not very familiar with asp.net stuff, so the code might be not in the
correct way.

## Usage

Put this file in your `App_Code` folder, in your `cs` file, set the message:

```cs
FlashMessage.Flash(this, "Wrong password, please try again");
```
In your 'aspx' file, to display the message that you set before:

```cs
<%
if (FlashMessage.Has(this)) {
    FlashMessage.Flash(this);
}
%>
```

Use `FlashMessage.Has` method to test if there has a message, remeber always pass
this (System.Web.UI.Page instance) to the method.

---

Copyright (c) 2015, Towry Wang
