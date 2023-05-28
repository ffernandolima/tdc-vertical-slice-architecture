﻿using FluentValidation;

namespace BankingApp.Transactions.API.Features.Earnings;

public class ApplyEarningsCommandValidator : AbstractValidator<ApplyEarningsCommand>
{
    public ApplyEarningsCommandValidator()
    {
        RuleFor(command => command.HolderId)
            .Must(holderId => holderId != Guid.Empty);

        RuleFor(command => command.Earnings)
            .GreaterThan(decimal.Zero);
    }
}