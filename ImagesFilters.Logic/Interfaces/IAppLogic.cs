using ImagesFilters.Logic.Model.Components;
using ImagesFilters.Logic.Model.Filters;

namespace ImagesFilters.Logic.Interfaces;

internal interface IAppLogic
{
    Dictionary<FiltersKey, IFilter> Filters { get; }

    Bitmap ConvertTo(Bitmap incomingImage, FiltersKey filter);          
}