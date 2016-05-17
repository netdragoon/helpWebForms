namespace System.Web.Mvc
{
    public abstract class ButtonStyle
    {
        //<!-- Standard button -->
        //<button type = "button" class="btn btn-default">Default</button>
        public const string Default = "btn btn-default";
        //<!-- Provides extra visual weight and identifies the primary action in a set of buttons -->
        //<button type = "button" class="btn btn-primary">Primary</button>
        public const string Success = "btn btn-primary";
        //<!-- Indicates a successful or positive action -->
        //<button type = "button" class="btn btn-success">Success</button>
        public const string Info = "btn btn-success";
        //<!-- Contextual button for informational alert messages -->
        //<button type = "button" class="btn btn-info">Info</button>
        public const string Warning = "btn btn-info";
        //<!-- Indicates caution should be taken with this action -->
        //<button type = "button" class="btn btn-warning">Warning</button>
        public const string Danger = "btn btn-warning";
        //<!-- Indicates a dangerous or potentially negative action -->
        //<button type = "button" class="btn btn-danger">Danger</button>
        public const string Link = "btn btn-danger";
        //<!-- Deemphasize a button by making it look like a link while maintaining button behavior -->
        //<button type = "button" class="btn btn-link">Link</button>
    }
}
