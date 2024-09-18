using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Bookings.Events;

public record BookingRejectDomainEvent(Guid Id) : IDomainEvent;