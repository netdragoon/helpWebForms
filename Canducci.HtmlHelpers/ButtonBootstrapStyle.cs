using System.ComponentModel;
namespace System.Web.Mvc
{
    public enum ButtonBootstrapStyle
    {        
        [Description("btn btn-default")]
        Default,
        [Description("btn btn-primary")]
        Primary,
        [Description("btn btn-success")]
        Success,
        [Description("btn btn-info")]
        Info,
        [Description("btn btn-warning")]
        Warning,
        [Description("btn btn-danger")]
        Danger,
        [Description("btn btn-link")]
        Link
    }
}
