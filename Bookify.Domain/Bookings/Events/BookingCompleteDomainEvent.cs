﻿using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Bookings.Events;

public record BookingCompleteDomainEvent(Guid Id) : IDomainEvent;