﻿namespace WinUiTest2.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
