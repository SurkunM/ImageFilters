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

        var filtersKeysCount = Enum.GetValues(typeof(FiltersKey)).Length;

        if (Filters.Count != filtersKeysCount)
        {
            throw new ArgumentException("Не все фильтры инициализированы или добавлены в 'FiltersKey'");
        }

        CreateUsedFiltersDictionary();
    }

    public Bitmap ConvertTo(Bitmap incomingImage, FiltersKey key)
    {
        if (Filters[key] is null)
        {
            throw new ArgumentNullException($"Фильтра с ключом ({key}) не существует");
        }

        if (IsFilterUsed(key))
        {
            return incomingImage;
        }

        if (key.Equals(FiltersKey.Original))
        {
            CreateUsedFiltersDictionary();
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

    public void CreateUsedFiltersDictionary()
    {
        _isFilterUsed = new Dictionary<FiltersKey, bool>();

        foreach (FiltersKey key in Filters.Keys)
        {
            _isFilterUsed[key] = false;
        }
    }
}