using Bookify.Application.Abstractions.Data;
using Bookify.Application.Abstractions.Messaging;
using Bookify.Domain.Abstractions;
using Dapper;

namespace Bookify.Application.Bookings.GetBooking;

internal sealed class GetBookingQueryHandler : IQueryHandler<GetBookingQuery, BookingResponse>
{
    private readonly ISqlConnectionFactory _sqlConnectionFactory;

    public GetBookingQueryHandler(ISqlConnectionFactory sqlConnectionFactory)
    {
        _sqlConnectionFactory = sqlConnectionFactory;
    }

    public async Task<Result<BookingResponse>> Handle(GetBookingQuery request, CancellationToken cancellationToken)
    {
        using var connection = _sqlConnectionFactory.CreateConnection();
        const string sql =
            """
            select id as Id,
            user_id as UserId,
            apartment_id as ApartmentId,
            status as Status,
            price_amount as PriceAmount,
            price_currency as PriceCurrency,
            cleaning_fee_amount as CleaningFeeAmount,
            cleaning_fee_currency as CleaningFeeCurrency,
            amenities_up_charge_amount as AmenitiesUpChargeAmount,
            amenities_up_charge_currency as AmenitiesUpChargeCurrency,
            total_price_amount as TotalPriceAmount,
            duration_start as DurationStart,
            duration_end as DurationEnd,
            create_on_utc as CreateOnUtc
            from bookings
            where id = @BookingId

            """;
        var booking = await connection.QueryFirstOrDefaultAsync<BookingResponse>(
            sql,
            new { request.BookingId });

        return booking;
    }
}