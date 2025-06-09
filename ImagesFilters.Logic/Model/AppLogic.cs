using ImagesFilters.Logic.Interfaces;
using ImagesFilters.Logic.Model.Components;
using ImagesFilters.Logic.Model.Filters;

namespace ImagesFilters.Logic.Model;

public class AppLogic : IAppLogic
{
    public Dictionary<FiltersKey, IFilter> Filters { get; }

    public FiltersKey UsedFilterKey { private get; set; }

    private Dictionary<FiltersKey, bool> _usedFilters = new Dictionary<FiltersKey, bool>();

    public AppLogic()
    {
        Filters = new Dictionary<FiltersKey, IFilter>
        {
            {FiltersKey.Original, new Original()},
            {FiltersKey.Blur, new Blur()},
            {FiltersKey.Sharpen, new Sharpen()},
            {FiltersKey.Aqua, new Aqua()},
            {FiltersKey.Embossing, new Embossing()},
            {FiltersKey.BlackAndWhite, new BlackAndWhite()}
        };

        var filtersKeysCount = Enum.GetValues(typeof(FiltersKey)).Length;

        if (Filters.Count != filtersKeysCount)
        {
            throw new Exception("Не все фильтры инициализированы или добавлены в 'FiltersKey'");
        }

        SetFiltersUnused();
    }

    public Bitmap ConvertTo(Bitmap incomingImage)
    {
        if (_usedFilters[UsedFilterKey] && (UsedFilterKey != FiltersKey.Blur && UsedFilterKey != FiltersKey.Sharpen))
        {
            return incomingImage;
        }

        if (UsedFilterKey == FiltersKey.Original)
        {
            SetFiltersUnused();
        }
        else
        {
            _usedFilters[UsedFilterKey] = true;
        }

        return Filters[UsedFilterKey].Convert(incomingImage);
    }

    public void SetFiltersUnused()
    {
        foreach (FiltersKey key in Filters.Keys)
        {
            _usedFilters[key] = false;
        }
    }
}