namespace Lands.Infrastructure
{
    using Lands.ViewModels;
    class InstanceLocator
    {
        #region Properties
        public MainViewModel Main { get; set; }
        #endregion

        #region Constructors
        public InstanceLocator()
        {
            //patron de diseño locator
            this.Main = new MainViewModel();        
        }
        #endregion
    }
}
