using Microsoft.AspNetCore.Mvc;

namespace FishingStore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        public string Invoke()
        {
            return "hello from the Nav Component";
        }
    }
}
