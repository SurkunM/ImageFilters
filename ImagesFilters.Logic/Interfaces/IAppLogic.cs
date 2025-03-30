using ImagesFilters.Logic.Model.Components;
using ImagesFilters.Logic.Model.Filters;

namespace ImagesFilters.Logic.Interfaces;

public interface IAppLogic
{
    Dictionary<FiltersKey, IFilter> Filters { get; }

    FiltersKey UsedFilterKey { set; }

    Bitmap ConvertTo(Bitmap incomingImage);
}