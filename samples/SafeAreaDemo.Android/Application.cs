﻿using Android.App;
using Android.Runtime;
using Avalonia.Android;

namespace SafeAreaDemo.Android
{
    [Application]
    public class Application : AvaloniaAndroidApplication<App>
    {
        protected Application(nint javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }
    }
}
