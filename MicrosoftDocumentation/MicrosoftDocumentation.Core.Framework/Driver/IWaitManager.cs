namespace MicrosoftDocumentation.Core.Framework.Driver
{
    using MicrosoftDocumentation.Core.Shared.Enums;
    public interface IWaitManager
    {
        void WaitPage(WaitType seconds);
    }
}
