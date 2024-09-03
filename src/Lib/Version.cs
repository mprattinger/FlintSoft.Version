using System.Reflection;

namespace FlintSoft.Version;

public class Version(Assembly assembly)
{
    public string GetVersion()
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
        }
        return ret;
    }
}
