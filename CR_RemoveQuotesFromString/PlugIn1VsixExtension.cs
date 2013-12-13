using System.ComponentModel.Composition;
using DevExpress.CodeRush.Common;

namespace CR_RemoveQuotesFromString
{
    [Export(typeof(IVsixPluginExtension))]
    public class CR_RemoveQuotesFromStringExtension : IVsixPluginExtension { }
}