// Decompiled with JetBrains decompiler
// Type: BDOServerRatesEditor.Properties.Resources
// Assembly: SimpleBDOServerConfig, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 881D590C-B119-4EFD-8186-52DDF3488E6A
// Assembly location: C:\Users\Admin\Documents\Новая папка (3)\SimpleBDOServerConfig.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace BDOServerRatesEditor.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (BDOServerRatesEditor.Properties.Resources.resourceMan == null)
          BDOServerRatesEditor.Properties.Resources.resourceMan = new ResourceManager("BDOServerRatesEditor.Properties.Resources", typeof (BDOServerRatesEditor.Properties.Resources).Assembly);
        return BDOServerRatesEditor.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return BDOServerRatesEditor.Properties.Resources.resourceCulture;
      }
      set
      {
        BDOServerRatesEditor.Properties.Resources.resourceCulture = value;
      }
    }

    internal static Bitmap Black_Desert1
    {
      get
      {
        return (Bitmap) BDOServerRatesEditor.Properties.Resources.ResourceManager.GetObject("Black-Desert1", BDOServerRatesEditor.Properties.Resources.resourceCulture);
      }
    }
  }
}
