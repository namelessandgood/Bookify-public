using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Bookings;

public static class BookingError
{
    public static Error NotFound = new(
        "Booking.Found",
        "Booking not found.");

    public static Error Overlap = new(
        "Booking.Overlap",
        "the current booking is overlap with an existing one");

    public static Error NotReserved = new(
        "Booking.NotReserved",
        "the booking is not reserved");

    public static Error NotConfirmed = new("Booking.NotReserved",
        "the booking is not confirmed");

    public static Error AlreadyStarted = new(
        "Booking.AlreadyStarted",
        "The booking has already started");

}