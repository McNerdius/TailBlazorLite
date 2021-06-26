using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Components;

namespace Client.Icons
{
    public partial class Icon : ComponentBase
    {
        private Dictionary<string, object> additionalAttributes = new();

        public string splattedClasses
            => additionalAttributes.TryGetValue( "class", out var classes ) ? classes as string : null;

        [Parameter( CaptureUnmatchedValues = true )]
        public Dictionary<string, object> AdditionalAttributes
        {
            get => additionalAttributes.Where( kvp => kvp.Key != "class" )
                                       .ToDictionary( kvp => kvp.Key, kvp => kvp.Value );
            set => additionalAttributes = value;
        }

        [Parameter]
        public string Text { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

    }
}