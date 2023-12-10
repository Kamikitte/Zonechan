using Zonechan.Core.InternalModels;
using Zonechan.Core.ResponseModels;

namespace Zonechan.Core.ZoneClient;

/// <summary>
/// Клиент для работы с API F95Zone
/// </summary>
public interface IZoneRequester
{
    /// <summary>
    /// Вовзвращает список игр
    /// </summary>
    /// <param name="page">Номер страницы</param>
    /// <param name="filter">Фильтр</param>
    public Task<IReadOnlyCollection<Game>> GetGamesFromPageAsync(int page, Filter? filter);
}