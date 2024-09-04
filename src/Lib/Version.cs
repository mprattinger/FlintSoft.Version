using System.Reflection;

namespace FlintSoft.Version;

public class Version(Assembly assembly)
{
    private string _version = "";
    public string GetVersion()
    {
        if (string.IsNullOrEmpty(_version))
        {
            var ret = "N/A";
            var attrs = assembly.GetCustomAttribute(typeof(AssemblyInformationalVersionAttribute));
            if (attrs != null)
            {
                var infoVerAttr = (AssemblyInformationalVersionAttribute)attrs;
                if (infoVerAttr != null && infoVerAttr.InformationalVersion.Length > 6)
                {
                    ret = infoVerAttr.InformationalVersion;
                }
                if (ret.Contains('+'))
                    {
                        ret = ret[..ret.IndexOf('+')];
                    }
            }
            _version = ret;
        }
        return _version;
    }
}
