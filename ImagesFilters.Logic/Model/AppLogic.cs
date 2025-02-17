using ImagesFilters.Logic.Interfaces;
using ImagesFilters.Logic.Model.Components;
using ImagesFilters.Logic.Model.Filters;

namespace ImagesFilters.Logic.Model;

public class AppLogic : IAppLogic
{
    public Dictionary<FiltersKey, IFilter> Filters { get; }

    public Dictionary<FiltersKey, bool> _isFilterUsed = default!;      

    public AppLogic()
    {
        Filters = new Dictionary<FiltersKey, IFilter>
        {
            {FiltersKey.Original, new Original()},
            {FiltersKey.Blur, new Blur(5)},
            {FiltersKey.Sharpen, new Sharpen()},
            {FiltersKey.Aqua, new Aqua()},
            {FiltersKey.Embossing, new Embossing()},
            {FiltersKey.BlackAndWhite, new BlackAndWhite()}
        };

        CreateFiltersDictionary();
    }

    public Bitmap ConvertTo(Bitmap incomingImage, IFilter filter)
    {
        return filter.Convert(incomingImage);
    }

    public Bitmap ConvertTo(Bitmap incomingImage, FiltersKey key)
    {
        if (IsFilterUsed(key))
        {
            return incomingImage;
        }

        return Filters[key].Convert(incomingImage);
    }

    private bool IsFilterUsed(FiltersKey key)
    {
        if (!_isFilterUsed[key] || key.Equals(FiltersKey.Blur) || key.Equals(FiltersKey.Sharpen))
        {
            _isFilterUsed[key] = true;

            return false;
        }

        return true;
    }

    private void CreateFiltersDictionary()
    {
        _isFilterUsed = new Dictionary<FiltersKey, bool>();

        foreach (FiltersKey key in Filters.Keys)
        {
            _isFilterUsed[key] = false;
        }
    }
}