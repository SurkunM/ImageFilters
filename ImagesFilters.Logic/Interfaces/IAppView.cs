using ImagesFilters.Logic.Model.Components;

namespace ImagesFilters.Logic.Interfaces;

public interface IAppView
{
     void SetImagePictureBox(FiltersKey filtersKey);

    void SetInDictionaryFilter(Bitmap image, FiltersKey filtersKey);
}
