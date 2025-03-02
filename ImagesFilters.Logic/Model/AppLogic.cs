using ImagesFilters.Logic.Interfaces;
using ImagesFilters.Logic.Model.Components;
using ImagesFilters.Logic.Model.Filters;

namespace ImagesFilters.Logic.Model;

public class AppLogic : IAppLogic, IAsyncConversionAppLogic
{
    public Dictionary<FiltersKey, bool> _isFilterUsed = default!;

    public Dictionary<FiltersKey, IFilter> Filters { get; }

    public FiltersKey UsedFilterKey { private get; set; } = default!;

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

        CreateIsUnusedFiltersDictionary();
    }

    public Bitmap ConvertTo(Bitmap incomingImage)
    {
        if (IsFilterUsed())
        {
            return incomingImage;
        }

        if (UsedFilterKey.Equals(FiltersKey.Original))
        {
            CreateIsUnusedFiltersDictionary();
        }

        return Filters[UsedFilterKey].Convert(incomingImage);
    }

    public async Task<Bitmap> ConvertToAsync(Bitmap incomingImage)
    {
        Bitmap? resultImage = null;

        await Task.Run(() =>
        {
            resultImage = ConvertTo(incomingImage);
        });

        return resultImage!;
    }

    private bool IsFilterUsed()
    {
        if (UsedFilterKey.Equals(FiltersKey.Blur) || UsedFilterKey.Equals(FiltersKey.Sharpen))
        {
            return false;
        }

        if (!_isFilterUsed[UsedFilterKey])
        {
            _isFilterUsed[UsedFilterKey] = true;

            return false;
        }

        return true;
    }

    public void CreateIsUnusedFiltersDictionary()
    {
        _isFilterUsed = new Dictionary<FiltersKey, bool>();

        foreach (FiltersKey key in Filters.Keys)
        {
            _isFilterUsed[key] = false;
        }
    }
}