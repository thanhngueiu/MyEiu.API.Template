﻿namespace MyEiu.API.Installer.Settings
{
    public interface IInstaller
    {
        void InstallServices(IServiceCollection services, IConfiguration configuration);
    }
}
