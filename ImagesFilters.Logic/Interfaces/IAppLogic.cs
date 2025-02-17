using ImagesFilters.Logic.Model.Filters;

namespace ImagesFilters.Logic.Interfaces;

internal interface IAppLogic
{
    Bitmap ConvertTo(Bitmap incomingImage, IFilter filter);          
}