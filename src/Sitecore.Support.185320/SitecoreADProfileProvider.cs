using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Profile;
using LightLDAP.Utility;
using Reflection = Sitecore.Reflection.ReflectionUtil;

namespace LightLDAP.Support
{
  public class SitecoreADProfileProvider: LightLDAP.SitecoreADProfileProvider
  {
    public override void Initialize(string name, NameValueCollection config)
    {
      base.Initialize(name, config);
      if (!ReflectionUtil.GetField<bool>(typeof(LightLDAP.SitecoreADProfileProvider), "isInitialized", this))
      {
        ReflectionUtil.SetField(typeof(System.Configuration.Provider.ProviderBase), "_name",this, name);
      }
    }
  }
}