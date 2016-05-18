using System.ComponentModel;
namespace System.Web.Mvc
{
    public enum ButtonSize
    {
        [Description()]
        Default,
        [Description("btn-sm")]
        Small,
        [Description("btn-xs")]
        ExtraSmall,
        [Description("btn-lg")]
        Large,
        [Description("btn-block")]
        DefaultAndBlock,
        [Description("btn-block btn-sm")]
        SmallAndBlock,
        [Description("btn-block btn-xs")]
        ExtraSmallAndBlock,
        [Description("btn-block btn-lg")]
        LargeAndBlock
    }
}
