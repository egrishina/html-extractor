namespace WebExtraction.Models
{
    internal record HotelDto
    (
        string Name,
        string Address,
        int Stars,
        double ReviewPoints,
        int ReviewsCount,
        string Description,
        string[] RoomCategories,
        AlternativeHotelDto[] AlternativeHotels
    );
}
