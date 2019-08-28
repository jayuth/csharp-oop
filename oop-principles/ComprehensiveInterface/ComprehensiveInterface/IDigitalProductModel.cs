using System;
namespace ComprehensiveInterface
{
    // by implementing IProductModel, it allows IDigitalProductModel to have access to all properties and method in IProductModel
    public interface IDigitalProductModel : IProductModel
    {
        int TotalDownloadsLeft { get; }
    }
}
